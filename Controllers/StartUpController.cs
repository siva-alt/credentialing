using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPTest.Controllers
{
    public class StartUpController : Controller
    {
        // GET: StartUp
        public ActionResult StartUpPage()
        {
            return View();
        }
    }
}