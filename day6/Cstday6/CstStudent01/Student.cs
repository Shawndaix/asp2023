using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstStudent01
{
    public class Student
    {
        // constructor

        public Student(string name, string gender, int age, int computer, int network, int python)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Computer = computer;
            this.Network = network;
            this.Python = python;
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
            set { 
                
                if (value<0 || value> 120)
                {
                    value = 0;
                }
                _age = value; }
        }

        private string _gender;

        public string Gender
        {
            get { 
                
                if (_gender != "Male" && _gender != "Female")
                {
                    return _gender = "Male";
                }

                return _gender; }
            set { _gender = value; }
        }

        private int _computer;

        public int Computer
        {
            get { return _computer; }
            set { _computer = value; }
        }

        private int _network;

        public int Network
        {
            get { return _network; }
            set { _network = value; }
        }

        private int _python;

        public int Python
        {
            get { return _python; }
            set { _python = value; }
        }




        public void SayHello()
        {
            Console.WriteLine("This is {0}\t, {1} years old\t, {2}",this.Name, this.Age, this.Gender);
            Console.ReadKey();
        }

        public void ShowScore()
        {
            int sum = this.Computer + this.Network + this.Python;
            int avg = sum / 3;
            Console.WriteLine("The {0}'s total score is {1} and average is {2}.", this.Name, Convert.ToString(sum), Convert.ToString(avg));

            Console.ReadKey();
        }

    }
}