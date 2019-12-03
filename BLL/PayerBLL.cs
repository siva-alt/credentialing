using ASPTest.Common;
using ASPTest.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPTest.BLL
{
    public class PayerBLL
    {
        Logging log = new Logging();
        public List<Ent_Payer> ViewAllPayer()
        {
            List<Ent_Payer> ent = null;
            try
            {
                log.MethodLog(" public Ent_Payer ViewAllPayer() method entry");
                //string Query = "SELECT * FROM Payer";
                string procedure = "ViewAllPayer";
                DynamicParameters param = new DynamicParameters();
                log.MethodLog(procedure + "Passed to database");
                ent = AtomORM.ExecuteProceduresReturnList<Ent_Payer>(procedure, param).ToList();
                log.MethodLog(procedure + " procedure executed with out error");
            }
            catch (Exception ex)
            {

                log.ExceptionLog(ex);
            }


            return ent;
        }
        public int AddPayer(Ent_Payer Payer)
        {
            int result = 0;
            try
            {
                log.MethodLog(" public int InsertintoPayer(Ent_Payer Payer) method entry");
                string Query = @"INSERT INTO dbo.Payer(
                                Payer_Name,Payer_Sub_Group_Name,Payer_Type,Address1,Address2,City,State,Zip_Code,Phone,Fax,Email,Contact_Person_Name,
                                Contact_Person_Designation,Mobile_Number,Website,Desk_Extn,Group_ID,Claim_Office_ID,
                                Payer_Medigap_Number,Status,Others,Attach_Forms_Type,ModifiedBy,ModifiedByDate) VALUES
                                (@Payer_Name,@Payer_Sub_Group_Name,@Payer_Type,@Address1,@Address2,@City,@State,@Zip_Code,@Phone,@Fax,@Email
                                ,@Contact_Person_Name,@Contact_Person_Designation,@Mobile_Number,@Website,@Desk_Extn,@Group_Id,@Claim_Office_ID
                                ,@Payer_Medigap_Number,@Status,@Others,@Attach_Forms_Type,@ModifiedBy,@ModifiedByDate)";
             
                log.MethodLog(Query + "Passed to database");
                result = AtomORM.ExecuteQuery(Query, AddParameters(Payer));
                log.MethodLog("Query executed with out error");
            }
            catch (Exception ex)
            {

                log.ExceptionLog(ex);
            }
            return result;
        }
        public DynamicParameters AddParameters(Ent_Payer Payer)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Payer_ID", Payer.Payer_ID);
                param.Add("@Payer_Name", Payer.Payer_Name);
                param.Add("@Payer_Sub_Group_Name", Payer.Payer_Sub_Group_Name);
                param.Add("@Payer_Type", Payer.Payer_Type);
                param.Add("@Address1", Payer.Address1);
                param.Add("@Address2", Payer.Address2);
                param.Add("@City", Payer.City);
                param.Add("@State", Payer.State);
                param.Add("@Zip_Code", Payer.Zip_Code);
                param.Add("@Phone", Payer.Phone);
                param.Add("@Fax", Payer.Fax);
                param.Add("@Email", Payer.Email);
                param.Add("@Contact_Person_Name", Payer.Contact_Person_Name);
                param.Add("@Contact_Person_Designation", Payer.Contact_Person_Designation);
                param.Add("@Mobile_Number", Payer.Mobile_Number);
                param.Add("@WebSite", Payer.WebSite);
                param.Add("@Desk_Extn", Payer.Desk_Extn);
                param.Add("@Group_ID", Payer.Group_ID);
                param.Add("@Claim_Office_ID", Payer.Claim_Office_ID);
                param.Add("@Payer_Medigap_Number", Payer.Payer_Medigap_Number);
                param.Add("@Status", Payer.Status);
                param.Add("@Others", Payer.Others);
                param.Add("@Attach_Forms_Type", Payer.Attach_Forms_Type);
                param.Add("@ModifiedBy", Payer.ModifiedBy);
                param.Add("@ModifiedByDate", Payer.ModifiedByDate.ToShortDateString());
                return param;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int UpdatePayer(Ent_Payer Payer)
        {
            int result = 0;
            try
            {
                log.MethodLog("public int UpdatePayer(Ent_Payer Payer) method entry");
                string Query = @"UPDATE [dbo].[Payer]
                                SET [Payer_Name] = @Payer_Name
                                   ,[Payer_Sub_Group_Name] = @Payer_Sub_Group_Name
                                   ,[Payer_Type] = @Payer_Type
                                   ,[Address1] = @Address1
                                   ,[Address2] = @Address2
                                   ,[City] = @City
                                   ,[State] = @State
                                   ,[Zip_Code] = @Zip_Code
                                   ,[Phone] = @Phone
                                   ,[Fax] = @Fax
                                   ,[Email] = @Email
                                   ,[Contact_Person_Name] = @Contact_Person_Name
                                   ,[Contact_Person_Designation] = @Contact_Person_Designation
                                   ,[Mobile_Number] =@Mobile_Number
                                   ,[WebSite] = @WebSite
                                   ,[Desk_Extn] = @Desk_Extn
                                   ,[Group_ID] = @Group_ID
                                   ,[Claim_Office_ID] = @Claim_Office_ID
                                   ,[Payer_Medigap_Number] = @Payer_Medigap_Number
                                   ,[Status] = @Status
                                   ,[Others] = @Others
                                   ,[Attach_Forms_Type] = @Attach_Forms_Type
                                   ,[ModifiedBy] = @ModifiedBy
                                   ,[ModifiedByDate] = @ModifiedByDate WHERE  WHERE Payer_ID=@Payer_ID";
               
                log.MethodLog(Query + "Passed to database");
                result = AtomORM.ExecuteQuery(Query, AddParameters(Payer));
                log.MethodLog("Query executed with out error");
            }
            catch (Exception ex)
            {

                log.ExceptionLog(ex);
            }
            return result;
        }
        public int DeletePayer(int PayerId)
        {
            int result = 0;
            try
            {
                log.MethodLog(" public int DeletePayer(int PayerId) method entry");
                string Query = "DELETE FROM dbo.Payer WHERE Payer_ID=@Payer_ID";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Payer_ID", PayerId);
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
        public Ent_Payer EditPayer(int PayerId)
        {
            Ent_Payer result = null;
            try
            {
                log.MethodLog(" public Ent_Payer EditPayer(int PayerId) method entry");
                string Query = "SELECT * FROM dbo.Payer WHERE Payer_ID=@Payer_ID";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Payer_ID", PayerId);
                log.MethodLog(Query + "Passed to database");
                result = AtomORM.ExecuteQueryResult<Ent_Payer>(Query, param).FirstOrDefault();
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