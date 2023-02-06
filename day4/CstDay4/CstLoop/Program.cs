using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //press "Shift" + "enter"
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine("{0} Welcome to Cst college!!!", i);
                i++;
            }
            #endregion

            #region
            // for loop
            for (int j = 0; j < 100; j++)
            {
                Console.WriteLine("{0} Welocome to Cst college!!!", j);
            }
            #endregion

            #region
            // do while statement
            int k = 0;

            do
            {
                Console.WriteLine("K{0} Welcome to Cst college!!!",k);
                k++;
            } while (k<100);
            #endregion


        }
    }
}
