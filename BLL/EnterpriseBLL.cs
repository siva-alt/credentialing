using ASPTest.Common;
using ASPTest.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPTest.BLL
{
    public class EnterpriseBLL
    {
        Logging log = new Logging();
        public List<Ent_Enterprise> ViewAllEnterprise()
        {
            List<Ent_Enterprise> ent = null;
            try
            {
                log.MethodLog(" public Ent_Enterprise ViewAllEnterprise() method entry");
                //string Query = "SELECT * FROM Enterprise";
                string procedure = "ViewAllEnterprise";
                DynamicParameters param = new DynamicParameters();
                log.MethodLog(procedure + "Passed to database");
                ent = AtomORM.ExecuteProceduresReturnList<Ent_Enterprise>(procedure, param).ToList();
                log.MethodLog(procedure + " procedure executed with out error");
            }
            catch (Exception ex)
            {

                log.ExceptionLog(ex);
            }
           

            return ent;
        }
        public int AddEnterprise(Ent_Enterprise Enterprise)
        {
           int result = 0;
            try
            {
                log.MethodLog(" public int InsertintoEnterprise(Ent_Enterprise Enterprise) method entry");
                string Query = @"INSERT INTO [dbo].[Enterprise]
                    ([Enterprise_Name],[Organization_Type] ,[Owner_Last_Name],[Owner_First_Name],[Title] ,[Taxonomy_Speciality],[Address1],[Address2],[City],[State]
		            ,[Zip_Code],[County],[Phone],[Fax],[Email] ,[Website],[Payto_Address] ,[Payto_City] ,[Payto_State],[Payto_Zip_code],[Tax_Id])
                      VALUES
                    (@Enterprise_Name,@Organization_Type,@Owner_Last_Name,@Owner_First_Name,@Title,@Taxonomy_Speciality,@Address1,@Address2,
		             @City,@State,@Zip_Code,@County,@Phone,@Fax,@Email,@Website ,@Payto_Address,@Payto_City,@Payto_State,@Payto_Zip_code,@Tax_Id)";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Enterprise_Name", Enterprise.Enterprise_Name);
                param.Add("@Organization_Type", Enterprise.Organization_Type);
                param.Add("@Owner_Last_Name", Enterprise.Owner_Last_Name);
                param.Add("@Owner_First_Name", Enterprise.Owner_First_Name);
                param.Add("@Title", Enterprise.Title);
                param.Add("@Taxonomy_Speciality", Enterprise.Taxonomy_Speciality);
                param.Add("@Address1", Enterprise.Address1);
                param.Add("@Address2", Enterprise.Address2);
                param.Add("@City", Enterprise.City);
                param.Add("@State", Enterprise.State);
                param.Add("@Zip_Code", Enterprise.Zip_Code);
                param.Add("@County", Enterprise.County);
                param.Add("@Phone", Enterprise.Phone);
                param.Add("@Fax", Enterprise.Fax);
                param.Add("@Email", Enterprise.Email);
                param.Add("@Website", Enterprise.Website);
                param.Add("@Payto_Address", Enterprise.Payto_Address);
                param.Add("@Payto_City", Enterprise.Payto_City);
                param.Add("@Payto_State", Enterprise.Payto_State);
                param.Add("@Payto_Zip_code", Enterprise.Payto_Zip_code);
                param.Add("@Tax_Id", Enterprise.Tax_Id);
                param.Add("@ModifiedBy", Enterprise.ModifiedBy);
                param.Add("@ModifiedByDate", Enterprise.ModifiedByDate.ToShortDateString());
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
        public int UpdateEnterprise(Ent_Enterprise Enterprise)
        {
            int result = 0;
            try
            {
                log.MethodLog("public int UpdateEnterprise(Ent_Enterprise Enterprise) method entry");
                string Query = @"UPDATE  [dbo].[Enterprise] SET
                    [Enterprise_Name]=@Enterprise_Name,[Organization_Type]= @Organization_Type ,[Owner_Last_Name]=@Owner_Last_Name,[Owner_First_Name]=@Owner_First_Name,
                    [Title]=@Title ,[Taxonomy_Speciality]=@Taxonomy_Speciality,[Address1]=@Address1,[Address2]=@Address2,[City]=@City,[State]=@State
		            ,[Zip_Code]=@Zip_Code,[County]=@County,[Phone]=@Phone,[Fax]=@Fax,[Email]=@Email ,[Website]=@Website,[Payto_Address]=@Payto_Address ,
                    [Payto_City]=@Payto_City ,[Payto_State]=@Payto_State,[Payto_Zip_code]=@Payto_Zip_code,[Tax_Id]=@Tax_Id WHERE Enterprise_ID=@Enterprise_ID";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Enterprise_ID", Enterprise.Enterprise_ID);
                param.Add("@Enterprise_Name", Enterprise.Enterprise_Name);
                param.Add("@Organization_Type", Enterprise.Organization_Type);
                param.Add("@Owner_Last_Name", Enterprise.Owner_Last_Name);
                param.Add("@Owner_First_Name", Enterprise.Owner_First_Name);
                param.Add("@Title", Enterprise.Title);
                param.Add("@Taxonomy_Speciality", Enterprise.Taxonomy_Speciality);
                param.Add("@Address1", Enterprise.Address1);
                param.Add("@Address2", Enterprise.Address2);
                param.Add("@City", Enterprise.City);
                param.Add("@State", Enterprise.State);
                param.Add("@Zip_Code", Enterprise.Zip_Code);
                param.Add("@County", Enterprise.County);
                param.Add("@Phone", Enterprise.Phone);
                param.Add("@Fax", Enterprise.Fax);
                param.Add("@Email", Enterprise.Email);
                param.Add("@Website", Enterprise.Website);
                param.Add("@Payto_Address", Enterprise.Payto_Address);
                param.Add("@Payto_City", Enterprise.Payto_City);
                param.Add("@Payto_State", Enterprise.Payto_State);
                param.Add("@Payto_Zip_code", Enterprise.Payto_Zip_code);
                param.Add("@Tax_Id", Enterprise.Tax_Id);
                param.Add("@ModifiedBy", Enterprise.ModifiedBy);
                param.Add("@ModifiedByDate", Enterprise.ModifiedByDate.ToShortDateString());
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
        public int DeleteEnterprise(int EnterpriseId)
        {
           int result = 0;
            try
            {
                log.MethodLog(" public int DeleteEnterprise(int EnterpriseId) method entry");
                string Query = "DELETE FROM dbo.Enterprise WHERE Enterprise_ID=@Enterprise_ID";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Enterprise_ID", EnterpriseId);
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
        public Ent_Enterprise EditEnterprise(int EnterpriseId)
        {
            Ent_Enterprise result = null;
            try
            {
                log.MethodLog(" public Ent_Enterprise EditEnterprise(int EnterpriseId) method entry");
                string Query = "SELECT * FROM dbo.Enterprise WHERE Enterprise_ID=@Enterprise_ID";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Enterprise_ID", EnterpriseId);
                log.MethodLog(Query + "Passed to database");
                result = AtomORM.ExecuteQueryResult<Ent_Enterprise>(Query, param).FirstOrDefault();
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