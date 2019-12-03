using ASPTest.Common;
using ASPTest.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPTest.BLL
{
    public class CompanyBLL
    {
        Logging log = new Logging();
        public List<Ent_Company> ViewAllCompany()
        {
            List<Ent_Company> ent = null;
            try
            {
                log.MethodLog(" public Ent_Company ViewAllEnterprise() method entry");
                //string Query = "SELECT * FROM Company";
                string procedure = "ViewAllCompany";
                DynamicParameters param = new DynamicParameters();
                log.MethodLog(procedure + "Passed to database");
                ent = AtomORM.ExecuteProceduresReturnList<Ent_Company>(procedure, param).ToList();
                log.MethodLog(procedure + " procedure executed with out error");
            }
            catch (Exception ex)
            {

                log.ExceptionLog(ex);
            }


            return ent;
        }
        public int AddComapny(Ent_Company Company)
        {
            int result = 0;
            try
            {
                log.MethodLog(" public int InsertintoEnterprise(Ent_Company Company) method entry");
                string Query = @"INSERT INTO [dbo].[Company]
                 ([Enterprise_ID],[Company_Name],[Organization_Type],[Taxonomy_Speciality],[Address1],[Address2],[City],[State],
		        [Zip_Code],[Country],[Phone] ,[Fax],[Email]  ,[Website],[Payto_Address],[Payto_City],[Payto_State] ,[Payto_Zip_Code] 
                ,[Tax_Id],[NPI] ,[ModifiedBy],[ModifiedByDate])
              VALUES
           (@Enterprise_ID,@Company_Name, @Organization_Type, @Taxonomy_Speciality, @Address1, @Address2,@City,
             @State,@Zip_Code,@Country,@Phone,@Fax,@Email, 
		   @Website,@Payto_Address,@Payto_City,@Payto_State, @Payto_Zip_Code,@Tax_Id,@NPI,@ModifiedBy, @ModifiedByDate)";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Enterprise_ID", Company.Enterprise_ID==0?1: Company.Enterprise_ID);
                param.Add("@Company_Name", Company.Company_Name);
                param.Add("@Organization_Type", Company.Organization_Type);
                param.Add("@Taxonomy_Speciality", Company.Taxonomy_Speciality);
                param.Add("@Address1", Company.Address1);
                param.Add("@Address2", Company.Address2);
                param.Add("@City", Company.City);
                param.Add("@State", Company.State);
                param.Add("@Zip_Code", Company.Zip_Code);
                param.Add("@Country", Company.Country);
                param.Add("@Phone", Company.Phone);
                param.Add("@Fax", Company.Fax);
                param.Add("@Email", Company.Email);
                param.Add("@Website", Company.Website);
                param.Add("@Payto_Address", Company.Payto_Address);
                param.Add("@Payto_City", Company.Payto_City);
                param.Add("@Payto_State", Company.Payto_State);
                param.Add("@Payto_Zip_Code", Company.Payto_Zip_Code);
                param.Add("@Tax_Id", Company.Tax_Id);  
                param.Add("@NPI", Company.NPI);
                param.Add("@ModifiedBy", Company.ModifiedBy);
                param.Add("@ModifiedByDate", Company.ModifiedByDate.ToShortDateString());
                log.MethodLog(Query + "Passed to database");
                result = AtomORM.ExecuteQuery(Query, param);
                log.MethodLog("Query executed with out error");
            }
            catch (Exception ex)
            {

                log.ExceptionLog(ex);
            }
            return result;
        }
        public int UpdateCompany(Ent_Company Company)
        {
            int result = 0;
            try
            {
                log.MethodLog("public int UpdateEnterprise(Ent_Company Company) method entry");
                string Query = @"UPDATE  [dbo].[Company] SET
                    [Company_Name]=@Company_Name,[Organization_Type]= @Organization_Type,[Taxonomy_Speciality]=@Taxonomy_Speciality,[Address1]=@Address1,[Address2]=@Address2,[City]=@City,[State]=@State
		            ,[Zip_Code]=@Zip_Code,[Country]=@Country,[Phone]=@Phone,[Fax]=@Fax,[Email]=@Email ,[Website]=@Website,[Payto_Address]=@Payto_Address ,
                    [Payto_City]=@Payto_City ,[Payto_State]=@Payto_State,[Payto_Zip_Code]=@Payto_Zip_Code,[Tax_Id]=@Tax_Id, [NPI]=@NPI  WHERE Enterprise_ID=@Enterprise_ID";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Company_Name", Company.Company_Name);
                param.Add("@Organization_Type", Company.OrganizationType);
                param.Add("@Taxonomy_Speciality", Company.Taxonomy_Speciality);
                param.Add("@Address1", Company.Address1);
                param.Add("@Address2", Company.Address2);
                param.Add("@City", Company.City);
                param.Add("@State", Company.State);
                param.Add("@Zip_Code", Company.Zip_Code);
                param.Add("@Country", Company.Country);
                param.Add("@Phone", Company.Phone);
                param.Add("@Fax", Company.Fax);
                param.Add("@Email", Company.Email);
                param.Add("@Website", Company.Website);
                param.Add("@Payto_Address", Company.Payto_Address);
                param.Add("@Payto_City", Company.Payto_City);
                param.Add("@Payto_State", Company.Payto_State);
                param.Add("@Payto_Zip_Code", Company.Payto_Zip_Code);
                param.Add("@Tax_Id", Company.Tax_Id);
                param.Add("@NPI", Company.NPI);
                param.Add("@ModifiedBy", Company.ModifiedBy);
                param.Add("@ModifiedByDate", Company.ModifiedByDate.ToShortDateString());
                log.MethodLog(Query + "Passed to database");
                result = AtomORM.ExecuteQuery(Query, param);
                log.MethodLog("Query executed with out error");
            }
            catch (Exception ex)
            {

                log.ExceptionLog(ex);
            }
            return result;
        }
        public int DeleteCompany(int Company_ID)
        {
            int result = 0;
            try
            {
                log.MethodLog(" public int DeleteEnterprise(int Company_ID) method entry");
                string Query = "DELETE FROM dbo.Company WHERE Company_ID=@Company_ID";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Company_ID", Company_ID);
                log.MethodLog(Query + "Passed to database");
                result = AtomORM.ExecuteQuery(Query, param);
                log.MethodLog("Query executed with out error");
            }
            catch (Exception ex)
            {

                log.ExceptionLog(ex);
            }
            return result;
        }
        public List<DDLList> EnterpriseList()
        {
            List<DDLList> result =null;
            try
            {
                log.MethodLog(" public int DeleteEnterprise(int Company_ID) method entry");
                string Query = "SELECT Enterprise_ID AS Code,Enterprise_Name As Description  FROM dbo.Enterprise ";
                DynamicParameters param = new DynamicParameters();
            
                log.MethodLog(Query + "Passed to database");
                var res = AtomORM.ExecuteQueryResult<DDLList>(Query, param).ToList();
                result = res;
                log.MethodLog("Query executed with out error");
            }
            catch (Exception ex)
            {

                log.ExceptionLog(ex);
            }
            return result;
        }

        public Ent_Company EditCompany(int Company_ID)
        {
            Ent_Company result = null;
            try
            {
                log.MethodLog(" public Ent_Company EditEnterprise(int Company_ID) method entry");
                string Query = "SELECT * FROM dbo.Company WHERE Company_ID=@Company_ID";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Company_ID", Company_ID);
                log.MethodLog(Query + "Passed to database");
                result = AtomORM.ExecuteQueryResult<Ent_Company>(Query, param).FirstOrDefault();
                result .EnterpriseList= EnterpriseList();
                
                log.MethodLog("Query executed with out error");
            }
            catch (Exception ex)
            {

                log.ExceptionLog(ex);
            }
            return result;
        }
    }
}