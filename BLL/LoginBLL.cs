using ASPTest.Common;
using ASPTest.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPTest.BLL
{
    public class LoginBLL
    {
        Logging log = new Logging();
        public Ent_Login login(Ent_Login login)
        {
            Ent_Login ent = null;
            try
            {
                log.MethodLog(" public Ent_Login login(Ent_Login login) entry");
                string Query = "SELECt * FROM dbo.Login WHERE UserName=@UserName AND  Password=@Password";
                DynamicParameters param = new DynamicParameters();
                param.Add("@UserName", login.UserName);
                param.Add("@Password", login.Password);
                log.MethodLog(Query + "Passed to database");
                ent = AtomORM.ExecuteQueryResult<Ent_Login>(Query, param).FirstOrDefault();
                log.MethodLog("Quary executed with out error");
            }
            catch (Exception ex)
            {

                log.ExceptionLog(ex);
            }
            return ent;
        }
    }
}