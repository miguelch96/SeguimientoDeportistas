//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using GroupSports.DL.DM;
//using GroupSportsWeb.ViewModels;

//namespace GroupSportsWeb.Controllers
//{
//    public class CoachsController : Controller
//    {
//        private group_sportsEntities db = new group_sportsEntities();

//        // GET: Coachs
//        public ActionResult Index()
//        {
//            LstCoachViewModel lstCoachViewModel = new LstCoachViewModel();
//            lstCoachViewModel.Fill();
//            return View(lstCoachViewModel);
//        }

//        // GET: Coachs/Details/5
//        public ActionResult Details(int id)
//        {

//            LstCoachViewModel lstCoachViewModel = new LstCoachViewModel();
//            lstCoachViewModel.FindById(id);
//            return View(lstCoachViewModel);
//        }

//        // GET: Coachs/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Coachs/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create( CoachDTO coachDTO)
//        {
//            if (coachDTO != null)
//            {
//                AddCoachViewModel addCoachViewModel = new AddCoachViewModel();
//                addCoachViewModel.AddCoach(coachDTO);
//                return RedirectToAction("Index");
//            }

//            return View(coachDTO);
//        }

//        // GET: Coachs/Edit/5
//        public ActionResult Edit(int id)
//        {

//            EditCoachViewModel editCoachViewModel = new EditCoachViewModel();
//            editCoachViewModel.FindById(id);
//            return View(editCoachViewModel);
//        }

//        // POST: Coachs/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit( CoachDTO coachDTO)
//        {
//            EditCoachViewModel editCoachViewModel = new EditCoachViewModel();
//            if (coachDTO != null)
//            {
                
//                editCoachViewModel.EditCoach(coachDTO);
//                return RedirectToAction("Index");
//            }
//            return View(editCoachViewModel);
//        }

//        // GET: Coachs/Delete/5
//        public ActionResult Delete(int id)
//        {
//            DeleteCoachViewModel deleteCoachViewModel = new DeleteCoachViewModel();
//            deleteCoachViewModel.FindById(id);
//            return View(deleteCoachViewModel);
//        }

//        // POST: Coachs/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            DeleteCoachViewModel deleteCoachViewModel = new DeleteCoachViewModel();
//            deleteCoachViewModel.DeleteCoach(id);
//            return RedirectToAction("Index");
//        }

//        //protected override void Dispose(bool disposing)
//        //{
//        //    if (disposing)
//        //    {
//        //        db.Dispose();
//        //    }
//        //    base.Dispose(disposing);
//        //}
//    }
//}
