using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    class Plane : Iflyable
    {
        public void Flying()
        {
            return;
            Console.WriteLine("I am plane, I can flying!!!");
        }

        public int Add()
        {
            return 16;
            Console.WriteLine("I am plane, I return 16.");
        }

        public void Speaking()
        {
            Console.WriteLine("I am plane, I make my speaking.");
        }

    }
}
