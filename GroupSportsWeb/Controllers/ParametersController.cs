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
//    public class ParametersController : Controller
//    {
//        private group_sportsEntities db = new group_sportsEntities();

//        // GET: Parameters
//        public ActionResult Index()
//        {
//            LstParameterViewModel lstParameterViewModel = new LstParameterViewModel();
//            lstParameterViewModel.listar();
//            return View(lstParameterViewModel);
//        }

//        // GET: Parameters/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            parameter parameter = db.parameter.Find(id);
//            if (parameter == null)
//            {
//                return HttpNotFound();
//            }
//            return View(parameter);
//        }

//        // GET: Parameters/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Parameters/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "id,parameterName")] parameter parameter)
//        {
//            if (ModelState.IsValid)
//            {
//                db.parameter.Add(parameter);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(parameter);
//        }

//        // GET: Parameters/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            parameter parameter = db.parameter.Find(id);
//            if (parameter == null)
//            {
//                return HttpNotFound();
//            }
//            return View(parameter);
//        }

//        // POST: Parameters/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "id,parameterName")] parameter parameter)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(parameter).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(parameter);
//        }

//        // GET: Parameters/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            parameter parameter = db.parameter.Find(id);
//            if (parameter == null)
//            {
//                return HttpNotFound();
//            }
//            return View(parameter);
//        }

//        // POST: Parameters/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            parameter parameter = db.parameter.Find(id);
//            db.parameter.Remove(parameter);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
