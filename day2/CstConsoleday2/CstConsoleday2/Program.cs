using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstConsolApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 25;
            int c = 35;
            int d = 10;
            int e;
            e = (a + b) * c / d;

            Console.WriteLine("(a+b)*c/d={0}", e);
            Console.ReadLine();

        }
    }
}
