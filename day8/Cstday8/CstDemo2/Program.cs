using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal[] animals =
            //{
            //    new Cat(),
            //    new Dog()
            //};

            //foreach (Animal aa in animals)
            //{
            //    aa.Speak();
            //}

            Animal a1 = new Cat();
            Animal a2 = new Dog();

            a1.Speak();
            a2.Speak();

            Console.ReadKey();
        }
    }
}
