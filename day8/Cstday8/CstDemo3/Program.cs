using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape c1 = new Circle(11);

            double area1 = c1.GetArea();
            double perimeter1 = c1.GetPerimeter();

            Ishape ifm1 = (Ishape)c1;
            string fmc1 = ifm1.FormulaOfArea();
            string fmc2 = ifm1.FormulaOfPerimeter();

            Console.WriteLine("The circle from sub-class:\t\n The area is {0:0.00},\t\n {1} \t\n The Perimeter is {2:0.00}.\t\n {3}", area1, fmc1, perimeter1, fmc2);


            Shape r1 = new Rectangle(16, 22);

            double area2 = r1.GetArea();
            double perimeter2 = r1.GetPerimeter();

            Ishape ifm2 = (Ishape)r1;
            string fmr1 = ifm2.FormulaOfArea();
            string fmr2 = ifm2.FormulaOfPerimeter();

            Console.WriteLine("The circle from sub-class:\t\n The area is {0:0.00},\t\n {1} \t\n The Perimeter is {2:0.00}.\t\n {3}", area2, fmr1, perimeter2, fmr2);

            Console.ReadKey();
        }
    }
}
