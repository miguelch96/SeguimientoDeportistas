using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using GroupSports.BL.BC;
using GroupSports.DL;
using GroupSportsWeb.ViewModels.Macrociclos;
using GroupSportsWeb.ViewModels.WorkPlans;

namespace GroupSportsWeb.Controllers
{
    public class MacrociclosController : Controller
    {
        public IMacrocicloService MacrocicloService { get; set; } = new MacrocicloService();
        public IWorkPlanService WorkPlanService { get; set; } = new WorkPlanService();

        public ActionResult Index(int? workplanid)
        {
            var vm = new LstMacrociclosViewModel
            {
                LstMacrociclos = MacrocicloService.Get(workplanid),
                Workplan = WorkPlanService.Get(workplanid.Value)
            };
            return View(vm);
        }

        public ActionResult AddEditMacrociclo(int? macrocicloId)
        {

            var vm = new AddEditMacrocicloViewModel();

            if (macrocicloId.HasValue)
            {
                var objMacrociclo = MacrocicloService.Find(macrocicloId.Value);
                vm.CargarDatos(objMacrociclo);
            }

            vm.LstWorkplans = WorkPlanService.Get();
            return View(vm);
        }

        [HttpPost]
        public ActionResult AddEditMacrociclo(AddEditMacrocicloViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    model.LstWorkplans = WorkPlanService.Get();
                    TryUpdateModel(model);
                    return View(model);
                }
                using (var transaction = new TransactionScope())
                {
                    var macrociclo = new MACROCICLO();

                    macrociclo.Name = model.Name;
                    macrociclo.Objective = model.Objective;
                    macrociclo.FechaInicio = DateTime.Today;
                    macrociclo.FechaFin = DateTime.Today.AddDays(5);
                    macrociclo.WorkPlanId = model.WorkplanId;
                    macrociclo.Estado = macrociclo.Estado;

                    if (model.MacrocicloId.HasValue)
                    {
                        MacrocicloService.Edit(macrociclo);
                    }
                    else
                    {
                        MacrocicloService.Add(macrociclo);
                    }
                    transaction.Complete();
                    return RedirectToAction("Index","Macrociclos", new{ workplanid = model.WorkplanId});
                }
            }
            catch (Exception ex)
            {
                var vm = new AddEditMacrocicloViewModel();
                vm.LstWorkplans = WorkPlanService.Get();
                TryUpdateModel(model);
                return View(vm);
            }
        }

        [HttpPost]
        public ActionResult DeleteMacrocilo(int macrocicloId)
        {
            try
            {
                MacrocicloService.Delete(macrocicloId);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}