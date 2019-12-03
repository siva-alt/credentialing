using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPTest.Models
{
    public class Ent_Employee
    {
        
        public int EmployeeID        { get; set; }
        public string EmployeeName      { get; set; }
        public string EmployeeAddress   { get; set; }
        public Boolean EmployeeGender    { get; set; }
    }
}