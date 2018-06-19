using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using GroupSports.BL.BC;
using GroupSports.DL;
using GroupSportsWeb.ViewModels.Sessions;
using GroupSportsWeb.ViewModels.WorkWeeks;

namespace GroupSportsWeb.Controllers
{
    public class SessionsController : Controller
    {
        public IWorkWeekService WorkWeekService { get; set; } = new WorkWeekService();
        public ISessionService SessionService { get; set; } = new SesionService();
        // GET: Session
        public ActionResult Index(int? workweekid)
        {
            var vm = new LstSessionsViewModel
            {
                Workweek = WorkWeekService.Find(workweekid.Value),
                LstSessions = SessionService.Get(workweekid)
            };
            return View(vm);
        }

        public ActionResult AddEditSession(int? sessionid)
        {
            var vm = new AddEditSessionViewModel();
            if (sessionid.HasValue)
            {
                var objSession = SessionService.Find(sessionid.Value);
                vm.CargarDatos(objSession);
            }

            vm.LstWorkweeks = WorkWeekService.Get(null);
            return View(vm);
        }

        [HttpPost]
        public ActionResult AddEditSession(AddEditSessionViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    model.LstWorkweeks = WorkWeekService.Get(null);
                    TryUpdateModel(model);
                    return View(model);
                }
                using (var transaction = new TransactionScope())
                {
                    var session = new SESION();

                    session.Nombre = model.Name;
                    session.Objective = model.Objective;
                    session.RegisterDate = DateTime.Now;
                    session.Asistencia = false;
                    session.Cumplimiento = false;
                    session.HoraAsistencia = null;
                    session.HoraCumplimiento = null;
                    session.Bitacora = model.Bitacora;
                    session.Estado = model.Estado;
                    session.WorkWeekId = model.WorkWeekId;

                    if (model.SessionId.HasValue)
                    {
                        SessionService.Edit(session);
                    }
                    else
                    {
                        SessionService.Add(session);
                    }
                    transaction.Complete();
                    return RedirectToAction("Index", new {workweekid = model.WorkWeekId});
                }
            }
            catch (Exception ex)
            {
                var vm = new AddEditSessionViewModel()
                {
                    LstWorkweeks = WorkWeekService.Get(null)
                };
                TryUpdateModel(model);
                return View(vm);
            }
        }

        [HttpPost]
        public ActionResult DeleteSession(int sessionid)
        {
            try
            {
                SessionService.Delete(sessionid);
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