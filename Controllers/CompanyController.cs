using ASPTest.BLL;
using ASPTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPTest.Controllers
{
    public class CompanyController : Controller
    {
        CompanyBLL bll = new CompanyBLL();
        // GET: Company
        [HttpGet]
        public ActionResult ViewAllCompany()
        {
            return View(bll.ViewAllCompany());
        }
        [HttpGet]
        public ActionResult Company(int id=0)
        {
            if (id != 0)
                return View(bll.EditCompany(id));
            else
            {
                Ent_Company com = new Ent_Company();
                com.EnterpriseList = bll.EnterpriseList();
                
                return View(com);
            }
               
        }
        [HttpPost]
        public ActionResult Company(Ent_Company com)
        {
            com.ModifiedBy = Session["UserName"].ToString();
            com.ModifiedByDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            if (com.Enterprise_ID == 0)
                bll.AddComapny(com);
            else
                bll.UpdateCompany(com);
            return RedirectToAction("ViewAllCompany");
           
        }
        [HttpGet]
        public ActionResult DeleteCompany(int id = 0)
        {
            bll.DeleteCompany(id);
            return RedirectToAction("ViewAllCompany");
        }
    }
}