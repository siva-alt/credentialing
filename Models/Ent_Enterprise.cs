using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPTest.Models
{
    public class Ent_Enterprise
    {
        public int Enterprise_ID { get; set; }
        [Required(ErrorMessage = "Enterprise Name is Required")]
        public string Enterprise_Name { get;set;}
        [Required]
        public int Organization_Type   {get;set;}
        [Required(ErrorMessage = "Organization Type is Required")]
        public string Owner_Last_Name     {get;set;}
        [Required(ErrorMessage = "Owner Last Name is Required")]
        public string Owner_First_Name    {get;set;}
        public string Title               {get;set;}
        public string Taxonomy_Speciality {get;set;}
        [Required(ErrorMessage = "Address1 is Required")]
        public string Address1            {get;set;}
        public string Address2            {get;set;}
        [Required(ErrorMessage = "City is Required")]
        public string City                {get;set;}
        [Required(ErrorMessage = "State is Required")]
        public string State               {get;set;}
        [Required(ErrorMessage = "Zip Code is Required")]
        public string Zip_Code              {get;set;}
        public string County              {get;set;}
        [Required(ErrorMessage = "Phone Number is Required")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Invalid Mobile Number")]
        public string Phone               {get;set;}
        
        [Required(ErrorMessage = "Fax Number is Required")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Invalid Fax Number")]
        public  double Fax { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email               {get;set;}
        public string Website             {get;set;}
        public string Payto_Address       {get;set;}
        public string Payto_City          { get;set;}
        public string Payto_State       { get;set;}
        public int Payto_Zip_code        { get;set;}
        [Required(ErrorMessage = "Tax ID is Required")]
        public string Tax_Id              {get;set;}
        public string ModifiedBy { get; set; }
        public DateTime ModifiedByDate { get; set; }

        //Fields only for dispaly the grid values
        public string OrganizationType { get; set; } 
        public string OwnerName { get; set; } 
        public string EnterpriseAddress { get; set; } 
        public string PayToAddress { get; set; }
    }
}