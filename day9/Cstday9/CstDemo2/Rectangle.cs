using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo2
{
    class Rectangle:IPolygon,IColor
    {
        public double CalculateArea(double a, double b)
        {
            
            Console.WriteLine("The retangle area is {0} .", Convert.ToString(a*b));

            return a * b;
        }

        //public double CalculatePerimeter(double a, double b)
        //{
        //    return 2 * (a + b);
        //}

        public void GetColor()
        {
            Console.WriteLine("the color of rectangle is blue.");
        }
    }
}
