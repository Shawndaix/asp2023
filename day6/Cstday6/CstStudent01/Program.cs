using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstStudent01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Tom", "Male", 18, 80, 98, 100);
            Student st2 = new Student("Alice", "Female", 20, 96, 97, 100);

            st1.SayHello();
            st1.ShowScore();

            st2.SayHello();
            st2.ShowScore();
        }
    }
}
