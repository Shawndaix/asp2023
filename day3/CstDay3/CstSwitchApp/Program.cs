using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstSwitchApp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Print out student mark according
             * Score
             */

            Console.WriteLine("Please input student's score (integer between 0~100)");
            // Convert str --> int
            int points = Convert.ToInt32(Console.ReadLine());

            #region
            switch (points / 10)
            {
                case 10:
                    Console.WriteLine("Great!");
                    break;
                case 9:
                    Console.WriteLine("Pefect!");
                    break;
                case 8:
                    Console.WriteLine("Good!");
                    break;
                case 7:
                    Console.WriteLine("Pass!");
                    break;
                case 6:
                    Console.WriteLine("Pass!");
                    break;

                default:
                    Console.WriteLine("Failed!!!");
                    break;
            }
            // End Swith
            #endregion
        }
    }
}
