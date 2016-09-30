using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inspinia_MVC5.Controllers
{
    
    [Authorize]
    public class DashboardsController : Controller
    {

        public ActionResult SuspectedPlague()
        {
            return View();
        }
        public ActionResult DiarrhoealDiseases()
        {
            return View();
        }
        public ActionResult CommunityDeaths()
        {
            return View();
        }
        public ActionResult AnimalDieOffs()
        {
            return View();
        }
        
        public ActionResult Dashboard_1()
        {
            return View();
        }

        public ActionResult Dashboard_2()
        {
            return View();
        }

        public ActionResult Overview()
        {
            return View();
        }

        public ActionResult Plague()
        {
            return View();
        }
        public ActionResult Dashboard_3()
        {
            return View();
        }
        
        public ActionResult Dashboard_4()
        {
            return View();
        }
        
        public ActionResult Dashboard_4_1()
        {
            return View();
        }

        public ActionResult Dashboard_5()
        {
            return View();
        }

    }
}