using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using GroupSports.BL.BC;
using GroupSports.DL;
using GroupSportsWeb.ViewModels.WorkPlans;

namespace GroupSportsWeb.Controllers
{
    public class WorkPlansController : Controller
    {
        public IWorkPlanService WorkPlanService { get; set; } = new WorkPlanService();

        // GET: WorkPlans
        public ActionResult Index()
        {
            var vm = new LstWorkPlanViewModel();
            vm.LstWorkplans = WorkPlanService.Get();
            return View(vm);
        }

        public ActionResult AddEditWorkplan(int? workplanId)
        {

            var viewModel = new AddEditWorkplanViewModel();

            if (workplanId.HasValue)
            {
                var objWorkplan = WorkPlanService.Get(workplanId.Value);
                viewModel.CargarDatos(objWorkplan);
            }

            //viewModel.LstTipoDocumento = context.TipoDocumento.ToList();
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
        public ActionResult DeleteWorkplan(int id)
        {
            try
            {
                WorkPlanService.Delete(id);
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