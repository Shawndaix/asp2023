using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CstDemo1
{
    public class SqlHelper
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        }

        public static readonly string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

        public static SqlConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public static int ExecuteNoQurey(SqlConnection conn, string cmdText, params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = cmdText;
                cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery();
            }
        }

        public static int ExecuteNoQuery(string cmtText, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                return ExecuteNoQurey(conn, cmtText, parameters);
            }
        }
    }
}