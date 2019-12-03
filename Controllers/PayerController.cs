using ASPTest.BLL;
using ASPTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPTest.Controllers
{
    public class PayerController : Controller
    {
        // GET: Payer
        PayerBLL bll = new PayerBLL();
        [HttpGet]
        public ActionResult ViewAllPayer()
        {

            return View(bll.ViewAllPayer());
        }
        [HttpGet]
        public ActionResult Payer(int id = 0)
        {
            if (id != 0)
                return View(bll.EditPayer(id));
            else
                return View();
        }
        [HttpPost]
        public ActionResult Payer(Ent_Payer Payer)
        {
            Payer.ModifiedBy = Session["UserName"].ToString();
            Payer.ModifiedByDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            if (Payer.Payer_ID == 0)
                bll.AddPayer(Payer);
            else
                bll.UpdatePayer(Payer);
            return RedirectToAction("ViewAllPayer");
        }
        [HttpGet]
        public ActionResult DeletePayer(int id)
        {
            bll.DeletePayer(id);
            return RedirectToAction("ViewAllPayer");
        }
    }
}