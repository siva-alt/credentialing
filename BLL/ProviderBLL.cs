using ASPTest.Common;
using ASPTest.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPTest.BLL
{
    public class ProviderBLL
    {
        Logging log = new Logging();
        public List<Ent_Provider> ViewAllProvider()
        {
            List<Ent_Provider> ent = null;
            try
            {
                log.MethodLog(" public Ent_Provider ViewAllProvider() method entry");
                //string Query = "SELECT * FROM Provider";
                string procedure = "ViewAllProvider";
                DynamicParameters param = new DynamicParameters();
                log.MethodLog(procedure + "Passed to database");
                ent = AtomORM.ExecuteProceduresReturnList<Ent_Provider>(procedure, param).ToList();
                log.MethodLog(procedure + " procedure executed with out error");
            }
            catch (Exception ex)
            {
                log.ExceptionLog(ex);
            }
            return ent;
        }
        public int AddProvider(Ent_Provider Provider)
        {
            int result = 0;
            try
            {
                log.MethodLog(" public int InsertintoProvider(Ent_Provider Provider) method entry");
                string Query = @"INSERT INTO dbo.Provider (
                                Facility_ID,Provider_Last_Name,Provider_First_Name,Provider_Middle_Name,Provider_Category,Working_Type,NPI
                                ,Speciality,Home_Phone,Cell_Number,Fax_Number,Email_ID,Specialty_License_ID,State_License_ID,Anesthesia_ID,UPIN_ID,Blue_Cross_ID,Champus_ID,Address1,Address2,City,State
                                ,Zip_Code,Country,Birth_Place,Date_Of_Birth,On_Board_Date,Relieving_Date,State_License_Effective_Date,DEA_Number,DEA_Effective_Date,CAQH_ID_Number
                                ,Professional_Experience,Status,Others,PECO,ModifiedBy,ModifiedByDate)
                                VALUES
                                (@Facility_ID,@Provider_Last_Name,@Provider_First_Name,@Provider_Middle_Name,@Provider_Category,@Working_Type,@NPI,@Speciality,@Home_Phone,@Cell_Number,
                                @Fax_Number,@Email_ID,@Specialty_License_ID,@State_License_ID,@Anesthesia_ID,@UPIN_ID,@Blue_Cross_ID,@Champus_ID,@Address1,@Address2,@City,@State,
                                @Zip_Code,@Country,@Birth_Place,@Date_Of_Birth,@On_Board_Date,@Relieving_Date,@State_License_Effective_Date,@DEA_Number,@DEA_Effective_Date,@CAQH_ID_Number,
                                @Professional_Experience,@Status,@Others,@PECO,@ModifiedBy,@ModifiedByDate)";
                result = AtomORM.ExecuteQuery(Query, AssignParameters(Provider));
                log.MethodLog("Query executed with out error");
            }
            catch (Exception ex)
            {

                log.ExceptionLog(ex);
            }
            return result;
        }
        public DynamicParameters AssignParameters(Ent_Provider Provider)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Facility_ID", Provider.Facility_ID);
                param.Add("@Provider_ID", Provider.Provider_ID);
                param.Add("@Provider_Last_Name", Provider.Provider_Last_Name);
                param.Add("@Provider_First_Name", Provider.Provider_First_Name);
                param.Add("@Provider_Middle_Name", Provider.Provider_Middle_Name);
                param.Add("@Provider_Category", Provider.Provider_Category);
                param.Add("@Working_Type", Provider.Working_Type);
                param.Add("@NPI", Provider.NPI);
                param.Add("@Speciality", Provider.Speciality);
                param.Add("@Home_Phone", Provider.Home_Phone);
                param.Add("@Cell_Number", Provider.Cell_Number);
                param.Add("@Fax_Number", Provider.Fax_Number);
                param.Add("@Email_ID", Provider.Email_ID);
                param.Add("@Specialty_License_ID", Provider.Specialty_License_ID);
                param.Add("@State_License_ID", Provider.State_License_ID);
                param.Add("@Anesthesia_ID", Provider.Anesthesia_ID);
                param.Add("@UPIN_ID", Provider.UPIN_ID);
                param.Add("@Blue_Cross_ID", Provider.Blue_Cross_ID);
                param.Add("@Champus_ID", Provider.Champus_ID);
                param.Add("@Address1", Provider.Address1);
                param.Add("@Address2", Provider.Address2);
                param.Add("@City", Provider.City);
                param.Add("@State", Provider.State);
                param.Add("@Zip_Code", Provider.Zip_Code);
                param.Add("@Country", Provider.Country);
                param.Add("@Birth_Place", Provider.Birth_Place);
                param.Add("@Date_Of_Birth", Provider.Date_Of_Birth);
                param.Add("@On_Board_Date", Provider.On_Board_Date);
                param.Add("@Relieving_Date", Provider.Relieving_Date);
                param.Add("@State_License_Effective_Date", Provider.State_License_Effective_Date);
                param.Add("@CAQH_ID_Number", Provider.CAQH_ID_Number);
                param.Add("@DEA_Number", Provider.DEA_Number); 
                param.Add("@DEA_Effective_Date", Provider.@DEA_Effective_Date);
                param.Add("@Professional_Experience", Provider.Professional_Experience);
                param.Add("@Status", Provider.Status);
                param.Add("@Others", Provider.Others);
                param.Add("@PECO", Provider.PECO);
                param.Add("@ModifiedBy", Provider.ModifiedBy);
                param.Add("@ModifiedByDate", Provider.ModifiedByDate.ToShortDateString());
                return param;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int UpdateProvider(Ent_Provider Provider)
        {
            int result = 0;
            try
            {
                log.MethodLog("public int UpdateProvider(Ent_Provider Provider) method entry");
                string Query = @"UPDATE dbo.Provider  SET
                    Facility_ID=@Facility_ID,Provider_Last_Name=@Provider_Last_Name,Provider_First_Name=@Provider_First_Name,
                    Provider_Middle_Name=@Provider_Middle_Name,Provider_Category=@Provider_Category,Working_Type=@Working_Type,NPI=@NPI
                    ,Speciality=@Speciality,Home_Phone=@Home_Phone,Cell_Number=@Cell_Number,Fax_Number=@Fax_Number,Email_ID=@Email_ID
                    ,Specialty_License_ID=@Specialty_License_ID,State_License_ID=@State_License_ID,Anesthesia_ID=@Anesthesia_ID
                    ,UPIN_ID=@UPIN_ID,Blue_Cross_ID=@Blue_Cross_ID,Champus_ID=@Champus_ID,Address1=@Address1,Address2=@Address2,City=@City,State=@State
                    ,Zip_Code=@Zip_Code,Country=@Country,Birth_Place=@Birth_Place,Date_Of_Birth=@Date_Of_Birth,On_Board_Date=@On_Board_Date
                    ,Relieving_Date=@Relieving_Date,State_License_Effective_Date=@State_License_Effective_Date
                    ,DEA_Number=@DEA_Number,DEA_Effective_Date=@DEA_Effective_Date,CAQH_ID_Number=@CAQH_ID_Number
                    ,Professional_Experience=@Professional_Experience,Status=@Status,Others=@Others,PECO=@PECO,
                    ModifiedBy=@ModifiedBy,ModifiedByDate=@ModifiedByDate WHERE Provider_ID=@Provider_ID";
                log.MethodLog(Query + "Passed to database");
                result = AtomORM.ExecuteQuery(Query, AssignParameters(Provider));
                log.MethodLog("Query executed with out error");
            }
            catch (Exception ex)
            {

                log.ExceptionLog(ex);
            }
            return result;
        }
        public int DeleteProvider(int ProviderId)
        {
            int result = 0;
            try
            {
                log.MethodLog(" public int DeleteProvider(int ProviderId) method entry");
                string Query = "DELETE FROM dbo.Provider WHERE Provider_ID=@Provider_ID";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Provider_ID", ProviderId);
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
        public Ent_Provider EditProvider(int ProviderId)
        {
            Ent_Provider result = null;
            try
            {
                log.MethodLog(" public Ent_Provider EditProvider(int ProviderId) method entry");
                string Query = "SELECT * FROM dbo.Provider WHERE Provider_ID=@Provider_ID";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Provider_ID", ProviderId);
                log.MethodLog(Query + "Passed to database");
                result = AtomORM.ExecuteQueryResult<Ent_Provider>(Query, param).FirstOrDefault();
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