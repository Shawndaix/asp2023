using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CstDemo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to CST college.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Unit 100, 80 Acadia Avenue, Markham, Ontario.";

            return View();
        }

        public ActionResult Service()
        {
            return View();
        }
    }
}