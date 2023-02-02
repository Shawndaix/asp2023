using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFunction
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Example 1
            //SayHello();
            ////Console.ReadLine();

            //void SayHello()
            //{
            //    Console.WriteLine("Weclcome to CST College!!!");
            //    Console.ReadKey();

            //}

            //Example 2

            string myStr = "Tom";
            string resultStr;

            resultStr = SayHello(myStr);

            Console.WriteLine(resultStr);

            Console.WriteLine(SayHello());

            Console.ReadKey();

            string SayHello(string str = "Joy")
            {
                string message = "Welcome to CST College:" + str;
                return message;
            }
        }
    }
}