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
            #region
            //int[] nums = new int[10]; //declare int array.
            ////nums[0] = 1;
            ////nums[1] = 5;
            ////nums[8] = 22;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i;
            //    Console.Write(nums[i]) ;
            //}


            //Console.ReadKey();
            #endregion

            // BUbble Sort.

            int[] nums = { 10,20,30,50,40,33,88,66};

            Console.WriteLine("Original Array:");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}  ",nums[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = 0; j < nums.Length-i-1; j++)
                {
                    if (nums[j]>nums[j+1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                } // internal for end.
            } //external for end.


            Console.WriteLine("Sorted Array:");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}  ", nums[i]);
            }
            Console.WriteLine();
        }
    }
}
