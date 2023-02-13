using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 12,34,11,8,28,7,35};

            for (int i = 0; i < nums.Length; i++)
            {
                for (int J = 0; J < nums.Length -i-1; J++)
                {
                    if (nums[J] < nums[J + 1]) 
                    {
                        int temp = nums[J];
                        nums[J] = nums[J + 1];
                        nums[J + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
