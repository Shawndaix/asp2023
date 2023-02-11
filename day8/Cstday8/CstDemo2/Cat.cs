using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo2
{
    public class Cat:Animal
    {
        public override void Speak()
        {
            Console.WriteLine("This is cat MiaoMiao from the child class.");   
        }
    }
}
