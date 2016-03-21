using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trydoit8.Controllers
{
    public class StartpageController : Controller
    {
        // GET: Startpage
        public ActionResult Index()
        {
            return View();
        }
    }
}