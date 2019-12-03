using Dapper;
using System;
using System.Data.SqlClient;
using System.IO;
namespace ASPTest.Common
{
    public class Logging
    {

        SqlConnection connection = null;
        private string FilePath = string.Empty;
        private string logFile = string.Empty;

        public Logging()
        {
            try
            {
                FilePath = AppDomain.CurrentDomain.BaseDirectory + "App_Data\\" + "log\\";
                CreateDirectory(FilePath);
                logFile = "Log_" + DateTime.Now.ToString("MM-dd-yyyy") + ".log";
                FilePath = CreateLogFile(FilePath, logFile);

            }
            catch (Exception)
            {

                throw;
            }
        }
        private string CreateLogFile(string filepath, String fileName)
        {
            filepath = filepath + fileName;
            if (!File.Exists(filepath))
            {
                File.Create(filepath).Close();
            }
            return filepath;
        }

        private void CreateDirectory(String path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public void ExceptionLog(Exception ex)
        {
            try
            {

                using (StreamWriter w = File.AppendText(FilePath))
                {
                    w.Write("\r\nException Log Entry : ");
                    w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                    w.WriteLine(" Error :{0}", ex.Message);
                    w.WriteLine(" Stack Trace :{0}", ex.StackTrace);
                    w.WriteLine("-------------------------------");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void MethodLog(string FromMethod)
        {
            try
            {
                using (StreamWriter w = File.AppendText(FilePath))
                {
                    w.WriteLine("{0}", DateTime.Now.ToLongDateString());
                    w.WriteLine(FromMethod);
                }
            }
            catch (Exception exce)
            {
                ExceptionLog(exce);
            }
        }
        public void InsertLogTable(string quary, String MethodName, String UserName, Exception ex)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@LogDateTime", DateTime.Now);
                param.Add("@MethodeName", MethodName);
                param.Add("@Quary", quary);
                param.Add("@UserName", UserName);
                if (ex != null)
                {
                    param.Add("@ErrorMessage", ex.Message);
                    param.Add("@StackTrace", ex.StackTrace);
                }
                string Quary = @"INSERT INTO Logtbl 
                      (LogDateTime,MethodeName,Quary,UserName,ErrorMessage,StackTrace)
                      VALUES(@LogDateTime,@MethodeName,@Quary,@UserName,@ErrorMessage,@StackTrace)";
                AtomORM.ExecuteQueryResult<int>(Quary);
            }
            catch (Exception exce)
            {

                ExceptionLog(exce);
            }
            finally
            {
                connection.Close();
            }
        }


    }
}