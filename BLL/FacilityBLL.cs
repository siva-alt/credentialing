using ASPTest.Common;
using ASPTest.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPTest.BLL
{
    public class FacilityBLL
    {
        Logging log = new Logging();
        public List<Ent_Facility> ViewAllFaclility()
        {
            List<Ent_Facility> ent = null;
            try
            {
                log.MethodLog(" public Ent_Facility ViewAllFacility() method entry");
                //string Query = "SELECT * FROM Facility";
                string procedure = "ViewAllFacility";
                DynamicParameters param = new DynamicParameters();
                log.MethodLog(procedure + "Passed to database");
                ent = AtomORM.ExecuteProceduresReturnList<Ent_Facility>(procedure, param).ToList();
                log.MethodLog(procedure + " procedure executed with out error");
            }
            catch (Exception ex)
            {

                log.ExceptionLog(ex);
            }


            return ent;
        }
        public int AddFaclility(Ent_Facility Facility)
        {
            int result = 0;
            try
            {
                log.MethodLog(" public int InsertintoEnterprise(Ent_Facility Facility) method entry");
                string Query = @"INSERT INTO [dbo].[Facility]
                    ([Company_ID] ,[Facility_Name],[Facility_Type],[NPI] ,[Taxonomy_Speciality],[Taxonomy_Description],[Sequence_Number],[Reference_Number],[Address1],[Address2],[City],[State]
		            ,[Zip_Code],[Phone],[Fax],[Email] ,[Tax_ID],[Claim_ID] ,[Location_Provider_ID] ,[Site_ID],[Place_of_Service],[ModifiedBy],[ModifiedByDate])
                      VALUES
                    (@Company_ID,@Facility_Name,@Facility_Type,@NPI,@Taxonomy_Speciality,@Taxonomy_Description,@Sequence_Number,@Reference_Number,@Address1,@Address2,
		             @City,@State,@Zip_Code,@Phone,@Fax,@Email,@Tax_ID ,@Claim_ID,@Location_Provider_ID,@Site_ID,@Place_of_Service,@ModifiedBy,@ModifiedByDate)";
               
                result = AtomORM.ExecuteQuery(Query, Assignparameters(Facility));
                log.MethodLog("Query executed with out error");
            }
            catch (Exception ex)
            {

                log.ExceptionLog(ex);
            }
            return result;
        }
        public DynamicParameters Assignparameters(Ent_Facility Facility)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
               
                param.Add("@Company_ID", 1);
                param.Add("@Facility_Name", Facility.Facility_Name);
                param.Add("@Facility_Type", Facility.Facility_Type);
                param.Add("@NPI", Facility.NPI);
                param.Add("@Taxonomy_Speciality", Facility.Taxonomy_Speciality);
                param.Add("@Taxonomy_Description", Facility.Taxonomy_Description);
                param.Add("@Sequence_Number", Facility.Sequence_Number);
                param.Add("@Reference_Number", Facility.Reference_Number);
                param.Add("@Address1", Facility.Address1);
                param.Add("@Address2", Facility.Address2);
                param.Add("@City", Facility.City);
                param.Add("@State", Facility.State);
                param.Add("@Zip_Code", Facility.Zip_Code);
                param.Add("@Phone", Facility.Phone);
                param.Add("@Fax", Facility.Fax);
                param.Add("@Email", Facility.Email);
                param.Add("@Tax_ID", Facility.Tax_ID);
                param.Add("@Claim_ID", Facility.Claim_ID);
                param.Add("@Location_Provider_ID", Facility.Location_Provider_ID);
                param.Add("@Site_ID", Facility.Site_ID);
                param.Add("@Locater_Code", Facility.Locater_Code);
                param.Add("@Place_of_Service", Facility.Place_of_Service);
                param.Add("@ModifiedBy", Facility.ModifiedBy);
                param.Add("@ModifiedByDate", Facility.ModifiedByDate.ToShortDateString());
                return param;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int UpdateFaclility(Ent_Facility Facility)
        {
            int result = 0;
            try
            {
                log.MethodLog("public int UpdateEnterprise(Ent_Facility Facility) method entry");
                string Query = @"UPDATE  [dbo].[Facility] SET
                    [Company_ID]=@Company_ID ,[Facility_Name]=@Facility_Name,[Facility_Type]=@Facility_Type,[NPI]=@NPI ,[Taxonomy_Speciality]=@Taxonomy_Speciality
                    ,[Taxonomy_Description]=Taxonomy_Description,[Address1]=@Address1,[Address2]=@Address2,[City]=@City,[State]=@State
		            ,[Zip_Code]=@Zip_Code,[Phone]=@Phone,[Fax]=@Fax,[Email]=@Email ,[Tax_ID]=@Tax_ID,[Claim_ID]=@Claim_ID ,[Location_Provider_ID] =@Location_Provider_ID,
                    [Site_ID]=@Site_ID,[Place_of_Service]=@Place_of_Service,[ModifiedBy]=@ModifiedBy,[ModifiedByDate]=@ModifiedByDate";

                log.MethodLog(Query + "Passed to database");
                result = AtomORM.ExecuteQuery(Query, Assignparameters(Facility));
                log.MethodLog("Query executed with out error");
            }
            catch (Exception ex)
            {

                log.ExceptionLog(ex);
            }
            return result;
        }
        public int DeleteFaclility(int FacilityId)
        {
            int result = 0;
            try
            {
                log.MethodLog(" public int DeleteEnterprise(int FacilityId) method entry");
                string Query = "DELETE FROM dbo.Facility WHERE Facility_ID=@Facility_ID";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Facility_ID", FacilityId);
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
        public Ent_Facility EditEnterprise(int FacilityId)
        {
            Ent_Facility result = null;
            try
            {
                log.MethodLog(" public Ent_Facility EditEnterprise(int FacilityId) method entry");
                string Query = "SELECT * FROM dbo.Facility WHERE Facility_ID=@Facility_ID";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Facility_ID", FacilityId);
                log.MethodLog(Query + "Passed to database");
                result = AtomORM.ExecuteQueryResult<Ent_Facility>(Query, param).FirstOrDefault();
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