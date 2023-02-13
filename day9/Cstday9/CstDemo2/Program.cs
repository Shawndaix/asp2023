using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.CalculateArea(22.5,11.4);
            r1.GetColor();

            //string str = string.Join(",", new string[] str={ 'a', 'b', 'c'});
        }
    }
}
