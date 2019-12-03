using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPTest.Models
{
    public class Ent_Provider
    {
        public int Provider_ID { get; set; }
        public int Facility_ID { get;set; }
        [Required(ErrorMessage = "Last Name is Required")]
        public string Provider_Last_Name { get;set;}
        [Required(ErrorMessage = "First Name is Required")]
        public string Provider_First_Name { get;set;}
        public string Provider_Middle_Name { get;set;}
        [Required(ErrorMessage = "Provider Category is Required")]
        public int Provider_Category { get;set;}
        public int Working_Type                     {get;set;}
        [Required(ErrorMessage = "NPI is Required")]
        public string NPI                              {get;set;}
        [Required(ErrorMessage = "Specility is Required")]
        public string Speciality { get;set;}
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Invalid Phone Number")]
        public string Home_Phone                       {get;set;}
        [Required(ErrorMessage = "Cell Number is Required")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Invalid phone Number")]
        public string Cell_Number                      {get;set;}
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Invalid pnone Number")]
        public string Fax_Number                      {get;set;}
        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email_ID                       {get;set;}
        public string Specialty_License_ID             {get;set;}
        public string State_License_ID                 {get;set;}
        public string Anesthesia_ID { get;set;}
        [Required(ErrorMessage = "UPIN is Required")]
        public string UPIN_ID            { get;set;}
        public string Blue_Cross_ID                    {get;set;}
        public string Champus_ID                       {get;set;}
        [Required(ErrorMessage = "Address is Required")]
        public string Address1                        {get;set;}
        public string Address2                        {get;set;}
        public string City                             {get;set;}
        public string State                            {get;set;}
        [Required(ErrorMessage = "Zip Code is Required")]
        public string Zip_Code                          {get;set;}
        public string Country                           {get;set;}
        public string Birth_Place                      {get;set;}
        [Required(ErrorMessage = "Date of birth is Required")]
        public DateTime Date_Of_Birth                    {get;set;}
        [Required(ErrorMessage = "Date of birth is Required")]
        public DateTime On_Board_Date                    {get;set;}
        [Required(ErrorMessage = "On Board Date is Required")]
        public DateTime Relieving_Date                   {get;set;}
        [Required(ErrorMessage = "State License Effective is Required")]
        public string State_License_Effective_Date { get;set;}
        public string DEA_Number                       {get;set;}
        public DateTime DEA_Effective_Date { get;set;}
        public string CAQH_ID_Number                   {get;set;}
        [Required(ErrorMessage = "Professional Experience   is Required")]
        public int Professional_Experience          {get;set;}
        public int Status                           {get;set;}
        public string Others                           {get;set;}
        public string PECO                             { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedByDate { get; set; }

        //This fields for grig view 
        public string ProviderCategory { get; set; }
        public string ProviderAddress { get; set; }
        public string ProviderStatus { get; set; } 
        public string ProvideName { get; set; }
    }
}