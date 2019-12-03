using ASPTest.Common;
using ASPTest.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPTest.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult ViewAll()
        {
            
            //return View(AtomORM.ExecuteProceduresReturnList<Ent_Employee>("ViewAllEmployee"));
            return View(AtomORM.ExecuteQueryResult<Ent_Employee>("SELECT * FROM Employee").ToList());
        }
        //  /Employee/AddorEdit/id
        [HttpGet]
        public ActionResult AddorEdit(int id=0)
        {
            DynamicParameters parm = new DynamicParameters();
            parm.Add("@EmployeeID", id);
            //return View(AtomORM.ExecuteProceduresReturnList<Ent_Employee>("EmployeeViesByID", parm).FirstOrDefault());
            return View(AtomORM.ExecuteQueryResult<Ent_Employee>("SELECT * FROM Employee WHERE EmployeeID=@EmployeeID", parm).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult AddorEdit(Ent_Employee emp)
        {
            DynamicParameters parm = new DynamicParameters();
            parm.Add("@EmployeeID", emp.EmployeeID);
            parm.Add("@EmployeeName",emp.EmployeeName);
            parm.Add("@EmployeeAddress", emp.EmployeeAddress);
            parm.Add("@EmployeeGender", emp.EmployeeGender);
            AtomORM.ExecuteProceduresWithoutReturn("proemployee", parm);
            return RedirectToAction("ViewAll");
        }
        public ActionResult Delete(int id)
        {
            DynamicParameters parm = new DynamicParameters();
            parm.Add("@EmployeeID", id);
            AtomORM.ExecuteProceduresWithoutReturn("EmployeeDeleteByID", parm);

            return RedirectToAction("ViewAll"); 
        }
    }
}