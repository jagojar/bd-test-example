using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd_testing.tests
{
    public static class SqlHelper
    {
        private static string ConnStr = @"Server = (localdb)\mssqllocaldb; Database = RegressionDB; Integrated Security = True";
        private static SqlConnection sqlConnection = new SqlConnection(ConnStr);

        public static DataTable GetDataTable(string queryStr)
        {
            //Connect to database            
            SqlCommand sqlCommand = new SqlCommand(queryStr, sqlConnection);
            sqlCommand.CommandType = CommandType.Text;

            //Run query            
            SqlDataAdapter sa = new SqlDataAdapter(sqlCommand);

            //Store result in table variable
            DataTable dt = new DataTable();
            sa.Fill(dt);

            //return table
            return dt;
        }

        public static DataTable GetDataTableFromStoredProcedure(string spName)
        {
            //Connect to test database            
            SqlCommand sqlCommand = new SqlCommand(spName, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            //Run query
            SqlDataAdapter sa = new SqlDataAdapter(sqlCommand);

            //Store result in table variable
            DataTable dt = new DataTable();
            sa.Fill(dt);

            //return table
            return dt;
        }
    }
}
