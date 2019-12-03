using ASPTest.BLL;
using ASPTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPTest.Controllers
{
    public class FacilityController : Controller
    {
        // GET: Facility
       
        FacilityBLL bll = new FacilityBLL();
        
        [HttpGet]
        public ActionResult ViewAllFacility()
        {

            return View(bll.ViewAllFaclility());
        }
        [HttpGet]
        public ActionResult Facility(int id = 0)
        {
            if (id != 0)
                return View(bll.EditEnterprise(id));
            else
                return View();
        }
        [HttpPost]
        public ActionResult Facility(Ent_Facility Facility)
        {
            Facility.ModifiedBy = Session["UserName"].ToString();
            Facility.ModifiedByDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            if (Facility.Facility_ID == 0)
                bll.AddFaclility(Facility);
            else
                bll.UpdateFaclility(Facility);
            return RedirectToAction("ViewAllFacility");
        }
        [HttpGet]
        public ActionResult DeleteFacility(int id)
        {
            bll.DeleteFaclility(id);
            return RedirectToAction("ViewAllFacility");
        }

    }
}