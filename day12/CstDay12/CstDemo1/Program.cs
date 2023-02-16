using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;


namespace CstDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server=SHAWN\\CSTSQLSERVER;uid=sa;pwd=005658;database=market";
            //server
            //uid: user ID
            //pwd:password
            //database


            SqlConnection conn = new SqlConnection(connStr);
            conn.Open(); //open DB
            Console.WriteLine("DB was opened!");
            Thread.Sleep(2000);


            //Console.ReadKey();
            conn.Close();
            Console.WriteLine("DB was closed!");
        }

    }
}
