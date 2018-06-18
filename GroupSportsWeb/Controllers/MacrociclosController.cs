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

        // GET: Macrociclos
        public ActionResult Index()
        {
            var vm = new LstMacrociclosViewModel
            {
                LstMacrociclos = MacrocicloService.Get()
            };
            return View();
        }

        public ActionResult ByWorkPlan(int workplanId)
        {
            var vm = new LstMacrociclosViewModel
            {
                LstMacrociclos = MacrocicloService.GetByWorkplan(workplanId),
                Workplan = WorkPlanService.Get(workplanId)
            };

            return View(vm);
        }

        public ActionResult AddEditMacrociclo(int? macrocicloId)
        {

            var vm = new AddEditMacrociclosViewModel();

            if (macrocicloId.HasValue)
            {
                var objMacrociclo = MacrocicloService.Get(macrocicloId.Value);
                vm.CargarDatos(objMacrociclo);
            }

            vm.LstCoachs = context.TipoDocumento.ToList();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult AddEditWorkplan(AddEditWorkplanViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    //model.LstTipoDocumento = context.TipoDocumento.ToList();
                    TryUpdateModel(model);
                    return View(model);
                }
                using (var transaction = new TransactionScope())
                {
                    var workplan = new WORKPLAN();

                    workplan.Name = model.Name;
                    workplan.Objective = model.Objective;
                    workplan.FechaInicio = DateTime.Today;
                    workplan.FechaFin = DateTime.Today.AddDays(5);
                    workplan.CoachId = 1;


                    if (model.WorkPlanId.HasValue)
                    {
                        workplan.WorkPlanId = model.WorkPlanId.Value;
                        WorkPlanService.Edit(workplan);
                    }
                    else
                    {
                        WorkPlanService.Add(workplan);
                    }
                    transaction.Complete();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                var vm = new AddEditWorkplanViewModel();
                //viewModel.LstTipoDocumento = context.TipoDocumento.ToList();
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