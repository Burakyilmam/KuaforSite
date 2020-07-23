using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tez.Controllers
{
    public class HizmetlerController : Controller
    {
        // GET: Hizmetler
        public ActionResult Hizmetler()
        {
            return View();
        }
        public ActionResult ErkekHizmetler()
        {
            return View();
        }
        public ActionResult KadınHizmetler()
        {
            return View();
        }
        public ActionResult GüzellikHizmetler()
        {
            return View();
        }
    }
}