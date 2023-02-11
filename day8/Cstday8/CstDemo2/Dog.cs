using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo2
{
    public class Dog:Animal
    {
        public override void Speak()
        {
            Console.WriteLine("This is dog barking from the child class.");
        }
    }
}
