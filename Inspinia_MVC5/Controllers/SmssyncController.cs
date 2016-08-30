using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inspinia_MVC5.Models;
using System.Diagnostics;

namespace Inspinia_MVC5.Controllers
{
    public class SmssyncController : Controller
    {
        // GET: Smssync
        
           
            public ActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public JsonResult PostMessage(UserModel data)
            {
               data.ToString();
                Debug.Assert(data != null);
                return Json(data);

            }
        

        public class UserModel
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }
    }
}