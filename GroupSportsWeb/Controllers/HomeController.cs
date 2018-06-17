//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using GroupSportsWeb.ViewModels;
//using GroupSports.DL.DM;

//namespace GroupSportsWeb.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ActionResult Login()
//        {
//            return View();
//        }
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Login(coach objUser)
//        {
//            if (ModelState.IsValid)
//            {
//                using (group_sportsEntities db = new group_sportsEntities())
//                {
//                    var obj = db.coach.Where(a => a.user.username.Equals(objUser.user.username) && a.user.password.Equals(objUser.user.password)).FirstOrDefault();
//                    if (obj != null)
//                    {
//                        Session["UserID"] = obj.userId.ToString();
//                        Session["UserName"] = obj.user.username.ToString();
//                        return RedirectToAction("Index");
//                    }
//                }
//            }
//            return View(objUser);
//        }

//        public ActionResult UserDashBoard()
//        {
//            if (Session["UserID"] != null)
//            {
//                return View();
//            }
//            else
//            {
//                return RedirectToAction("Login");
//            }
//        }

//        public ActionResult Index()
//        {
            
//            LstIndexViewModel listar = new LstIndexViewModel();
//            listar.Listar();
//            return View(listar);
//        }

//        public ActionResult About()
//        {
//            ViewBag.Message = "Your application description page.";

//            return View();
//        }

//        public ActionResult Contact()
//        {
//            ViewBag.Message = "Your contact page.";

//            return View();
//        }
//    }
//}