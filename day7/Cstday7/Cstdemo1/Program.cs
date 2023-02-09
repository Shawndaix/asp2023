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
            Cat cat1 = new Cat("Tom", 12, 009);

            cat1.SayHello();
            cat1.Speak();

            //cat.Sleeping();
            Console.ReadKey();

            Cat cat2 = new Cat("Bob", 20, 100);
            cat2.SayHello();
            cat2.Speak();
        }
    }
}
