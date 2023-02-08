using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    public class Person
    {
        // field
        //public string _name;
        //public string _gender;
        //public int _age;
#region //def property
        private string _name; // field, belong to class

        public string Name  //property
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }


        private int _age;

        public int Age
        {
            get { return _age; }
            set { 
                
                if (value<0 || value>120 )
                {
                    value = 0;
                }

                    _age = value; }
        }

        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set { 
                
                if (value=="Male" || value=="Female")
                    {
                        _gender = value; 
                    }
                else
                    {
                        value = "None";
                        _gender = value;
                    }

                    

            }
        }

        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }


        #endregion

        // constructor
        public Person(string name, string gender, int age, int height)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Height = height;
        }

        public Person(string name, string gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }

        // method
        public void Speak()
        {
            Console.WriteLine("This is {0}\t, I am {1} years old, \t {2}, {3}", this._name, this._age, this._gender, this.Height);
        }

        public void Walk()
        {
            Console.WriteLine("I am walking!!!");
        }

        public static void MakeMoney()
        {
            Console.WriteLine("This is static method, I am working hard to make money!!!");
        }
    }
}
