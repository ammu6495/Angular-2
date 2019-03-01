using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoapp.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getstring()
        {
            return View();
        }
        public ActionResult getstudent()
        {
            return View();
        }
	}
}