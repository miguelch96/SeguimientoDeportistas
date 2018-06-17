using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GroupSportsWeb.ViewModels;

namespace GroupSportsWeb.Controllers
{
    public class WorkWeekController : Controller
    {
        // GET: WorkWeek
        public ActionResult Index(int id)
        {
            LstWorkWeeksViewModel lstWorkWeeksViewModel = new LstWorkWeeksViewModel();
            lstWorkWeeksViewModel.findAll(id);
            
            return View(lstWorkWeeksViewModel);
        }

        // GET: WorkWeek/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WorkWeek/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkWeek/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WorkWeek/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WorkWeek/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WorkWeek/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WorkWeek/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
