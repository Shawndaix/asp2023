using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloopEvenresult
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = 1000;

            for (int i = 1; i <= n; i+=2)
            {
                sum += i;
            }
            Console.WriteLine("the output is {0}", sum);
            Console.ReadLine();
        }
    }
}
