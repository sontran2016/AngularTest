using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace TestAngular.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //line 1
            //line 2 aa
            //line 3
            return View();
        }
        public ActionResult TestRouting()
        {
            return View();
        }
        public ActionResult TestAngular()
        {
            return View();
        }
        public ActionResult Main()
        {
            return View();
        }
        public ActionResult Red()
        {
            return View();
        }
        public ActionResult Green()
        {
            return View();
        }
        public ActionResult Blue()
        {
            return View();
        }
    }
}
