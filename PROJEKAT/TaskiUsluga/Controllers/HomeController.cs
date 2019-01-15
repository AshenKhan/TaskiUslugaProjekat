using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskiUsluga.Models;

namespace TaskiUsluga.Controllers
{
    public class HomeController : Controller
    {
        BazaPodataka bz = new BazaPodataka();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}