using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo3
{
    public class Circle : Shape, Ishape
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        // constractor

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Sqrt(this.Radius);
        }

        public override double GetPerimeter()
        {
            return Math.PI * 2 * this.Radius; 
        }

        public string FormulaOfArea()
        {
            return "The Formula of Circle's Area: PI * Square(Radius).\t\n";
        }

        public string FormulaOfPerimeter()
        {
            return "The Formula of Circle's Perimeter: 2* PI * Radius.\t\n";
        }

    }
}
