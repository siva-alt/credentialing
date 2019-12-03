using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPTest.Models
{
    public class Ent_Company
    {
        public int Company_ID { get; set; } 
        public int Enterprise_ID { get; set; }
        [Required(ErrorMessage = "Company Name is Required")]
        public string Company_Name { get;set;}  
       public string  Organization_Type    {get;set;}
       public string  Taxonomy_Speciality  {get;set;}
        [Required(ErrorMessage = "Address1 is Required")]
        public string  Address1             {get;set;}
       public string  Address2             {get;set;}
        [Required(ErrorMessage = "City is Required")]
        public string  City                 {get;set;}
        [Required(ErrorMessage = "State is Required")]
        public string  State                {get;set;}
        [Required(ErrorMessage = "Zip Code is Required")]
        public int  Zip_Code                  {get;set;}
       public string  Country               {get;set;}
        [Required(ErrorMessage = "Phone Number is Required")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Invalid Mobile Number")]
        public string  Phone                {get;set;}
       
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Invalid Fax Number")]
        public string  Fax                  {get;set;}
        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string  Email                {get;set;}
       public string  Website              {get;set;}
        [Required(ErrorMessage = "Pay to address is Required")]
        public string  Payto_Address        {get;set;}
       public string Payto_City            { get;set;}
       public string Payto_State           { get;set;}
       public int Payto_Zip_Code        { get;set;}
        [Required(ErrorMessage = "Tax Id is Required")]
        public string  Tax_Id               {get;set;}
        [Required(ErrorMessage = "NPI is Required")]
        public string  NPI                 {get;set;}
       public string ModifiedBy { get; set; }
        public DateTime ModifiedByDate { get; set; }

        //This set of fields for grid view
        public string OrganizationType { get; set; }
        public string CompanyAddress { get; set; }
        public string PayToAddress { get; set; }
        public List<DDLList> EnterpriseList { get; set; }
    }
}