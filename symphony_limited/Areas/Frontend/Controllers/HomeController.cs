using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace symphony_limited.Areas.Frontend.Controllers
{
    public class HomeController : Controller
    {
        // GET: Frontend/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}