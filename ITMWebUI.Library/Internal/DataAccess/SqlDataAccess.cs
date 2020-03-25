using Dapper;
using ITMWebUI.Library.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ITMWebUI.Library.Internal.DataAccess
{
    internal static class SqlDataAccess
    {
        // TODO - Create the database connection
        // Link for procedure:
        // https://dotnetcoretutorials.com/2019/08/05/dapper-in-net-core-part-2-dapper-query-basics/

        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ITMData;Integrated Security=SSPI";

        public static List<OperationModel> GetOperationData()
        {
            List<OperationModel> output = new List<OperationModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var queryResponse = connection.Query<OperationModel>("SELECT * FROM dbo.Operation");

                output = queryResponse.AsList<OperationModel>();

                return output;
            }
        }

        //public static List<T> LoadData()
        //{
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {

        //        }

        //    }
        //    catch (System.Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
