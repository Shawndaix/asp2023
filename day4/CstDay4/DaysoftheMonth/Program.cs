using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysoftheMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            string flag = "year";
            // get year
            Console.WriteLine("Please input year___");

            try
            {
                // try year 
                int year = Convert.ToInt32(Console.ReadLine());

                flag = "month";
                // get month
                Console.WriteLine("Please inout Month___");
                int month = Convert.ToInt32(Console.ReadLine());

                int day = 0;
                switch (month)
                {
                    // month 1 3 5 7 8 10 12
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        day = 31;
                        break;

                    /* month 2
                     * 
                     * leap year
                     * 
                     * 1. (year % 400 ==0) || (year %4 ==0 && year % 100!=0)
                     * 2. function: isleapyear()
                     * 
                    */
                    case 2:
                        if (DateTime.IsLeapYear(year))
                        {
                            day = 29;
                        }
                        else
                        {
                            day = 28;
                        }
                        break;

                    // month 4 6 9 11
                    default:
                        day = 30;
                        break;
                } // switch end

                Console.WriteLine("The year {0}, the month {1} has {2} days", year, month, day);

            } // year try end

            catch (Exception ex)   
            {
                Console.WriteLine("The {0} is invalid, program exit!!!", flag);
                Console.WriteLine("The error message is {0}", ex.GetType().FullName);
                //throw ex;
            }
        }
    }
}
