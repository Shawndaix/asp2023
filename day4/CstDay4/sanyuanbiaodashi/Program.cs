using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanyuanExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input one number:__");
            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please inout second number:__");
            int a2 = Convert.ToInt32(Console.ReadLine());

            int max = a1 > a2 ? a1 : a2;

            Console.WriteLine("The Max number between {0} and {1} is {2}.", a1, a2, max);

            //if (a1 >a2)
            //{
            //    Console.WriteLine("the max number is {0}", a1);
            //}
            //else
            //{
            //    Console.WriteLine("the max number is {0}", a2);
        }
    }
}
