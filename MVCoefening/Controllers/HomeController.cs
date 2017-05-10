using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCoefening.Models;

namespace MVCoefening.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new Huis());
        }

        public ActionResult About()
        {
            return View();
        }
    }
}