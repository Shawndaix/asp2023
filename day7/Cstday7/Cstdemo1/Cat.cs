using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    public class Cat:Animal
    {
        // constuctor
        public Cat(string name, int age, int ID) : base(name,age)
        {
            //this.Name = name;
            //this.Age = age;
            this.ID = ID;
        }
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public void Speak()
        {
            Console.WriteLine("I am {0}, {1} years old, ID number is {2}", this.Name, this.Age, this.ID);
            //Sleeping();

        }
    }
}