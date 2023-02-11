using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo
{
    class Staff:Person
    {
        public void StaffSpeak()
        {
            Console.WriteLine("This is child class of staff.");
        }
    }
}
