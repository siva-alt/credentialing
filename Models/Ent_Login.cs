using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPTest.Models
{
    public class Ent_Login
    {
        public int ID { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public int Roles { get; set; }
       
    }
}