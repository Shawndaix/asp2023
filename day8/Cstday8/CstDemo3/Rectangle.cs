using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo3
{
    public class Rectangle:Shape, Ishape
    {
        private double _length;

        public double length
        {
            get { return _length; }
            set { _length = value; }
        }

        private double _width;

        public double width
        {
            get { return _width; }
            set { _width = value; }
        }

        // constractor
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // override method.
        public override double GetArea()
        {
            return  this.width * this.length ;
        }

        public override double GetPerimeter()
        {
            return 2 * (this.width + this.length);
        }

        string Ishape.FormulaOfArea()
        {
            return "The Formula of Retangle's Area: Width * Length.\t\n";
        }

        string Ishape.FormulaOfPerimeter()
        {
            return "The Formula of Retangle's Perimeter: 2 * (Width + Length).\t\n";
        }

    }
}
