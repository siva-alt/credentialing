using ASPTest.BLL;
using ASPTest.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPTest.Controllers
{
    public class LoginController : Controller
    {
        LoginBLL bll = new LoginBLL();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Verify(Ent_Login login)
        {

            Ent_Login data = bll.login(login);
            if (data!=null)
            {
                Session["UserName"] = login.UserName;
                Session["Roles"] = login.Roles;
               
                return RedirectToAction("StartUpPage", "StartUp"); 
            }
            else
            {
                
                ViewBag.errormessage = "User Name and Password Invalid";
                return View("Login");
            }
            
        }
        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();  //Clear Session Values
            return RedirectToAction("Login","Login");
        }
    }
}