using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    public class Person
    {
        public string _name; // class person, one field(_name).
        public string _gender;
        public int _age;

        public void M1()
        {
            Console.WriteLine("This is not static method of the person!!");
        }

        public static void M2()
        {
            Console.WriteLine("This is static method of the person!");
        }
    }
}