using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPTest.Models
{
    public class Ent_Payer
    {
        public int Payer_ID                   {get;set;}
        public string Payer_Name                 {get;set;}
        public string Payer_Sub_Group_Name       {get;set;}
        public int Payer_Type                 {get;set;}
        public string Address1                  {get;set;}
        public string Address2                  {get;set;}
        public string City                       {get;set;}
        public string State                      {get;set;}
        public int Zip_Code                   {get;set;}
        public string Phone                      {get;set;}
        public string Fax                        {get;set;}
        public string Email                      {get;set;}
        public string WebSite                   {get;set;}
        public string Contact_Person_Name        {get;set;}
        public string Contact_Person_Designation {get;set;}
        public string Mobile_Number              {get;set;}
        public string Desk_Extn                {get;set;}
        public int Group_ID                 {get;set;}
        public string Claim_Office_ID            {get;set;}
        public string Payer_Medigap_Number     {get;set;}
        public int  Status                     {get;set;}
        public string Others                     {get;set;}
        public string Attach_Forms_Type     {get;set;}
        public string ModifiedBy { get; set; }
        public DateTime ModifiedByDate { get; set; }

        //This fields are used for grid view
        public string PayerAddress { get; set; }
        public string PayerStatus { get; set; }

    }
}