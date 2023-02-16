using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;

namespace CstDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "uid=sa;pwd=005658;server=SHAWN\\CSTSQLSERVER;database=market";
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                #region
                

                // new sql command object

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                //open DB
                conn.Open();

                cmd.CommandText= "INSERT INTO dbo.Customers(customerContact,customerCity,customerBirthday)VALUES('Bob','Mississauga','1980-01-01 00:00:00.000');";
                int nums=cmd.ExecuteNonQuery();
                if (nums!=0)
                {
                    Console.WriteLine("insert {0}\t records succesfully!",nums);
                }
                #endregion
            } // end try

            catch
            {
                Console.WriteLine("Something is wrong! Open DB failure, Please check!");
            }

            finally
            {
                conn.Close();
            }
        }
    }
}
