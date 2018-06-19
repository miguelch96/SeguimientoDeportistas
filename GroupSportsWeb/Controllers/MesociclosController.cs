using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using GroupSports.BL.BC;
using GroupSports.DL;
using GroupSportsWeb.ViewModels.Mesociclos;

namespace GroupSportsWeb.Controllers
{
    public class MesociclosController : Controller
    {
        public IMacrocicloService MacrocicloService { get; set; } = new MacrocicloService();
        public IMesocicloService MesocicloService { get; set; } = new MesocicloService();

        // GET: Mesociclos
        public ActionResult Index(int? macrocicloid)
        {
            var vm = new LstMesociclosViewModel
            {
                LstMesociclos = MesocicloService.Get(macrocicloid),
                Macrociclo = MacrocicloService.Find(macrocicloid.Value)
            };
            return View(vm);
        }

        public ActionResult AddEditMesociclo(int? mesocicloId)
        {

            var vm = new AddEditMesocicloViewModel();

            if (mesocicloId.HasValue)
            {
                var objMesociclo = MesocicloService.Find(mesocicloId.Value);
                vm.CargarDatos(objMesociclo);
            }

            vm.LstMacrociclos = MacrocicloService.Get(null);
            return View(vm);
        }

        [HttpPost]
        public ActionResult AddEditMesociclo(AddEditMesocicloViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    model.LstMacrociclos = MacrocicloService.Get(null);
                    TryUpdateModel(model);
                    return View(model);
                }
                using (var transaction = new TransactionScope())
                {
                    var mesociclo = new MESOCICLO();

                    mesociclo.Name = model.Name;
                    mesociclo.Objective = model.Objective;
                    mesociclo.FechaInicio = DateTime.Today;
                    mesociclo.FechaFin = DateTime.Today.AddDays(5);
                    mesociclo.MacrocicloId = model.MacrocicloId;
                    mesociclo.Estado = model.Estado;

                    if (model.MesocicloId.HasValue)
                    {
                        MesocicloService.Edit(mesociclo);
                    }
                    else
                    {
                        MesocicloService.Add(mesociclo);
                    }
                    transaction.Complete();
                    return RedirectToAction("Index", new {macrocicloid = model.MacrocicloId});
                }
            }
            catch (Exception ex)
            {
                var vm = new AddEditMesocicloViewModel
                {
                    LstMacrociclos = MacrocicloService.Get(null)
                };
                TryUpdateModel(model);
                return View(vm);
            }
        }

        [HttpPost]
        public ActionResult DeleteMesociclo(int mesocicloId)
        {
            try
            {
                MesocicloService.Delete(mesocicloId);
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