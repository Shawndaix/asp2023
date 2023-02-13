using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bird
            Bird b1 = new Bird();
            b1.Flying();
            b1.Taxcalculator();
            Console.WriteLine(b1.Add());
            b1.Speaking();

            Console.ReadKey();

            //
            Plane p1 = new Plane();
            p1.Flying();
            Console.WriteLine(p1.Add());
            p1.Speaking();
        }
    }
}
