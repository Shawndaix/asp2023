using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    public class Animal

    {
        //constructor
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public void SayHello()
        {
            Console.WriteLine("This is {0}\t, I am {1} year old.", this.Name, this.Age);
        }

        //public void Move()
        //{
        //    Console.WriteLine("I am running!!!");
        //}

        //private void Eat()
        //{
        //    Console.WriteLine("This is my private food!!!");
        //}

        //protected void Sleeping()
        //{
        //    Console.WriteLine("I am sleeping by protected!!!");
        //}
    }
}
