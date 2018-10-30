using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Github_demo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Addnewstudent()
        {
            return View();
        }

        public ActionResult DeleteSt()
        {
            return View();
        }

        public ActionResult SearchSt()
        {
            ViewBag.i = 45;
            return View();
        }

        public ActionResult abc()
        {
            return View();
        }

    }
}