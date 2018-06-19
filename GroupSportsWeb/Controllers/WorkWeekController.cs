using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using GroupSports.BL.BC;
using GroupSports.DL;
using GroupSportsWeb.ViewModels;
using GroupSportsWeb.ViewModels.Mesociclos;
using GroupSportsWeb.ViewModels.WorkWeeks;
using LstWorkWeeksViewModel = GroupSportsWeb.ViewModels.WorkWeeks.LstWorkWeeksViewModel;

namespace GroupSportsWeb.Controllers
{
    public class WorkWeekController : Controller
    {
        public IWorkWeekService WorkWeekService { get; set; } = new WorkWeekService();
        public IMesocicloService MesocicloService { get; set; } = new MesocicloService();
        // GET: WorkWeek
        public ActionResult Index(int? mesocicloid)
        {
            var vm = new LstWorkWeeksViewModel
            {
                LstWorkweeks = WorkWeekService.Get(mesocicloid),
                Mesociclo = MesocicloService.Find(mesocicloid.Value)
            };
            return View(vm);
        }

        public ActionResult AddEditWorkWeek(int? workweekid)
        {
            var vm = new AddEditWorkWeekViewModel();
            if (workweekid.HasValue)
            {
                var objWorkWeek = WorkWeekService.Find(workweekid.Value);
                vm.CargarDatos(objWorkWeek);
            }

            vm.LstMesociclos = MesocicloService.Get(null);
            return View(vm);
        }

        [HttpPost]
        public ActionResult AddEditWorkWeek(AddEditWorkWeekViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    model.LstMesociclos = MesocicloService.Get(null);
                    TryUpdateModel(model);
                    return View(model);
                }
                using (var transaction = new TransactionScope())
                {
                    var workweek = new WORKWEEK();

                    workweek.Nombre = model.Name;
                    workweek.Objective = model.Objective;
                    workweek.FechaInicio = DateTime.Today;
                    workweek.FechaFin = DateTime.Today.AddDays(5);
                    workweek.MesocicloId = model.MesocicloId;
                    workweek.Estado = model.Estado;

                    if (model.WorkWeekId.HasValue)
                    {
                        WorkWeekService.Edit(workweek);
                    }
                    else
                    {
                        WorkWeekService.Add(workweek);
                    }
                    transaction.Complete();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                var vm = new AddEditWorkWeekViewModel()
                {
                    LstMesociclos = MesocicloService.Get(null)
                };
                TryUpdateModel(model);
                return View(vm);
            }
        }

        [HttpPost]
        public ActionResult DeleteWorkWeek(int workweekid)
        {
            try
            {
                WorkWeekService.Delete(workweekid);
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
