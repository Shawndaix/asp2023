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
            Person p1 = new Person("Tom","Male",20);
            //p1.Name = "Tom";
            //p1.Age = 20;
            //p1.Gender = "Male";



            p1.Speak();
            p1.Walk();

            Console.ReadKey();

            Person p2 = new Person("Alice","Tiger",18);
            //p2.Name = "Alice";
            //p2.Age = -10;
            //p2.Gender = "Tiger";

            p2.Speak();
            p2.Walk();

            Console.ReadKey();

            Person p3 = new Person("Bob","Hungey",200);
            //p3.Name = "Bob";
            //p3.Age = 200;
            //p3.Gender = "I am hungry!!!";

            p3.Speak();
            p3.Walk();

            Console.ReadKey(); // alt + F12

            Person p5 = new Person("Anderson", "Male", 600, 2);
            p5.Speak();

            Person.MakeMoney();

            Console.ReadKey();


        }
    }
}
