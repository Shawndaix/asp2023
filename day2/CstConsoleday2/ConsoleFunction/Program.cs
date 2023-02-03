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
                string mess1 = "Happy Chinese New Year 2023!";
                string mess2 = "Welocome!!!";

                // string message = "Welcome to CST College:" + str;
                string message = $"Welcome to CST College {str}  {mess1}  {mess2}";
                return message;

            }
        }
    }
}