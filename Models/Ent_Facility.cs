using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPTest.Models
{
    public class Ent_Facility
    {
        public int Facility_ID { get; set; }
        public int Company_ID { get;set;}
        [Required(ErrorMessage = "Facility Name is Required")]
        public string Facility_Name        {get;set;}
        public string Facility_Type        {get;set;}
        [Required(ErrorMessage = "NPI is Required")]
        public string NPI                  {get;set;}
        public string Taxonomy_Speciality { get;set;}
        public string Taxonomy_Description {get;set;}
        public double Sequence_Number      {get;set;}
        public double Reference_Number     {get;set;}
        [Required(ErrorMessage = "NPI is Required")]
        public string Address1            {get;set;}
        public string Address2            {get;set;}
        public string City                 {get;set;}
        public string State                {get;set;}
        public string Zip_Code             {get;set;}
        [Required(ErrorMessage = "Phone Number is Required")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Invalid Mobile Number")]
        public string Phone                  {get;set;}
        [Required(ErrorMessage = "Phone Number is Required")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Invalid Fax Number")]
        public string Fax                  {get;set;}
        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email                {get;set;}
        [Required(ErrorMessage = "Tax ID is Required")]
        public string Tax_ID               {get;set;}
        [Required(ErrorMessage = "Claim ID is Required")]
        public string Claim_ID             {get;set;}
        public string Location_Provider_ID {get;set;}
        public string Site_ID              {get;set;}
        [Required(ErrorMessage = "Locater Code is Required")]
        public string Locater_Code { get;set;}
        [Required(ErrorMessage = "Place of Service is Required")]
        public int Place_of_Service     { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedByDate { get; set; }


        //This are fields for grid view 
        public string FacilityType { get; set; }
        public string FacilityAddress { get; set; }
    }
}