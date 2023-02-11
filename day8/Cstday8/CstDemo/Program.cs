using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Staff sf1 = new Staff();
            //Person p1 = sf1;


            Staff st1 = new Staff();

            //st1.StaffSpeak();
            //st1.Speak();
            Console.ReadKey();

            Person p1 = new Person();
            p1.Speak();


            Staff st2 = new Staff();
            st2 = (Staff)p1;
            st2.StaffSpeak();
            st2.Speak();

            //Console.WriteLine("p1 is {0}", p1.GetType().Name);

            //if (st2 is Person p)
            //{
            //    Console.WriteLine("st2 is {0}", st2.GetType().Name);
            //    p1 = (Staff)st2;
            //}
            //else
            //{
            //    Console.WriteLine("st2 is not a Person, st2 is {0}", st2.GetType().Name);
            //}


            //st2.StaffSpeak();
            //Console.ReadKey();


            //string str = string.Join("=",new string[] { "Tom","Joey","Alice","Bob"});
            //Console.WriteLine(str);
            //Console.ReadKey();
        }

    }
}
