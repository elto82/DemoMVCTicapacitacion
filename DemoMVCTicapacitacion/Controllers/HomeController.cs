using DemoMVCTicapacitacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVCTicapacitacion.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Repository R = new Repository();
            var Model = R.GetDemo();
            return View(Model);
        }
    }
}