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
//    public class AthletesController : Controller
//    {
//        private group_sportsEntities db = new group_sportsEntities();

//        // GET: Athletes
//        public ActionResult Index()
//        {
//            //var athelete = db.athelete.Include(a => a.discipline).Include(a => a.team).Include(a => a.user);
//            //return View(athelete.ToList());
//            LstAthleteViewModel listatl = new LstAthleteViewModel();
//            listatl.listAthletes();
//            return View(listatl);
//        }

//        // GET: Athletes/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            athelete athelete = db.athelete.Find(id);
//            if (athelete == null)
//            {
//                return HttpNotFound();
//            }
//            return View(athelete);
//        }

//        // GET: Athletes/Create
//        public ActionResult Create()
//        {
//            ViewBag.disciplineId = new SelectList(db.discipline, "id", "discipline_name");
//            ViewBag.teamId = new SelectList(db.team, "id", "teamName");
//            ViewBag.userId = new SelectList(db.user, "id", "username");
//            return View();
//        }

//        // POST: Athletes/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "id,disciplineId,userId,teamId")] athelete athelete)
//        {
//            if (ModelState.IsValid)
//            {
//                db.athelete.Add(athelete);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.disciplineId = new SelectList(db.discipline, "id", "discipline_name", athelete.disciplineId);
//            ViewBag.teamId = new SelectList(db.team, "id", "teamName", athelete.teamId);
//            ViewBag.userId = new SelectList(db.user, "id", "username", athelete.userId);
//            return View(athelete);
//        }

//        // GET: Athletes/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            athelete athelete = db.athelete.Find(id);
//            if (athelete == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.disciplineId = new SelectList(db.discipline, "id", "discipline_name", athelete.disciplineId);
//            ViewBag.teamId = new SelectList(db.team, "id", "teamName", athelete.teamId);
//            ViewBag.userId = new SelectList(db.user, "id", "username", athelete.userId);
//            return View(athelete);
//        }

//        // POST: Athletes/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "id,disciplineId,userId,teamId")] athelete athelete)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(athelete).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.disciplineId = new SelectList(db.discipline, "id", "discipline_name", athelete.disciplineId);
//            ViewBag.teamId = new SelectList(db.team, "id", "teamName", athelete.teamId);
//            ViewBag.userId = new SelectList(db.user, "id", "username", athelete.userId);
//            return View(athelete);
//        }

//        // GET: Athletes/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            athelete athelete = db.athelete.Find(id);
//            if (athelete == null)
//            {
//                return HttpNotFound();
//            }
//            return View(athelete);
//        }

//        // POST: Athletes/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            athelete athelete = db.athelete.Find(id);
//            db.athelete.Remove(athelete);
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
