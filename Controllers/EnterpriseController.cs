using ASPTest.BLL;
using ASPTest.Common;
using ASPTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPTest.Controllers
{
    public class EnterpriseController : Controller
    {
        EnterpriseBLL bll = new EnterpriseBLL();
        // GET: Enterprise
        [HttpGet]
        public ActionResult ViewAllEnterprise()
        {

            return View(bll.ViewAllEnterprise());
        }
        [HttpGet]
        public ActionResult Enterprise(int id=0)
        {
            if(id!=0)
            return View(bll.EditEnterprise(id));
            else
            return View();
        }
        [HttpPost]
        public ActionResult Enterprise(Ent_Enterprise Enterprise)
        {
                Enterprise.ModifiedBy = Session["UserName"].ToString();
                Enterprise.ModifiedByDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                if(Enterprise.Enterprise_ID==0)
                     bll.AddEnterprise(Enterprise);
                else
                    bll.UpdateEnterprise(Enterprise);
                return RedirectToAction("ViewAllEnterprise");
        }
        [HttpGet]
        public ActionResult DeleteEnterprise(int id)
        {
            bll.DeleteEnterprise(id);
            return RedirectToAction("ViewAllEnterprise");
        }
    }
}