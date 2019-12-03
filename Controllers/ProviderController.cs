using ASPTest.BLL;
using ASPTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPTest.Controllers
{
    public class ProviderController : Controller
    {

        ProviderBLL bll = new ProviderBLL();
        // GET: Provider
        [HttpGet]
        public ActionResult ViewAllProvider()
        {

            return View(bll.ViewAllProvider());
        }
        [HttpGet]
        public ActionResult Provider(int id = 0)
        {
            if (id != 0)
                return View(bll.EditProvider(id));
            else
                return View();
        }
        [HttpPost]
        public ActionResult Provider(Ent_Provider Provider)
        {
            Provider.ModifiedBy = Session["UserName"].ToString();
            Provider.ModifiedByDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            if (Provider.Provider_ID == 0)
                bll.AddProvider(Provider);
            else
                bll.UpdateProvider(Provider);
            return RedirectToAction("ViewAllProvider");
        }
        [HttpGet]
        public ActionResult DeleteProvider(int id)
        {
            bll.DeleteProvider(id);
            return RedirectToAction("ViewAllProvider");
        }
    }
}