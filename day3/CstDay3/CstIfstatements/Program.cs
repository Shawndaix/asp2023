using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstIfstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter One Integer Number:");
            int nums = Convert.ToInt32(Console.ReadLine());
            if (nums % 2 == 0)
            {
                Console.WriteLine("The number : {0} you input is EVEN!", nums);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The number : {0} you input is ODD!", nums);
            }


        }
    }
}
