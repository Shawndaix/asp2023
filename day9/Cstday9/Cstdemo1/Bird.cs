using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    public class Bird : Iflyable, ITaxcau
    {
        public void Flying()
        {
            Console.WriteLine("I am bird, I can flying!!!");
        }

        public void Taxcalculator()
        {
            Console.WriteLine("This is tax calculator of bird!!!");
        }

        public int Add()
        {
            return 12;
            Console.WriteLine("I am bird, I return 12.");
        }
        //{

        //}

        public void Speaking()
        {
            Console.WriteLine("This is speaking of bird.");
        }

    }
}
