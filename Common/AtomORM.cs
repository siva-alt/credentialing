using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ASPTest.Common
{
    public class AtomORM
    {

        private static string connectionstring = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;

        //This is for Procedure that not return any output
        public static void ExecuteProceduresWithoutReturn(string procudurename, DynamicParameters parm = null)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                sqlcon.Execute(procudurename, parm, commandType: CommandType.StoredProcedure);
            }
        }


        //AtomORM.ExecuteQuaryReturnMultipleRow<classname>(_,_); This is for Select
        public static IEnumerable<T> ExecuteQueryResult<T>(string Quary, DynamicParameters parm = null)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                var res= sqlcon.Query<T>(Quary, parm, commandType: CommandType.Text);
                return res;
            }
        }
        //This is for insert update and delete
        public static int ExecuteQuery(string Quary, DynamicParameters parm = null)
        {

            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                return sqlcon.Execute(Quary, parm, commandType: CommandType.Text);
            }

        }

        //AtomORM.ExecuteProceduresReturnList<classname>(_,_) This is for Procedure that return Result
        public static IEnumerable<T> ExecuteProceduresReturnList<T>(string procudurename, DynamicParameters parm = null)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                return sqlcon.Query<T>(procudurename, parm, commandType: CommandType.StoredProcedure);
            }
        }
    }
}