using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inspinia_MVC5.Controllers
{
    
    public class MetricsController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Alerts()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult ProjectPerformance()
        {
            return View();
        }
    }
}