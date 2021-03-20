using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Demo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Welcome action method
        /// </summary>
        /// <returns></returns>
        public ActionResult Welcome()
        {
             ViewBag.v = "234";
            return View();
        }
    }
}