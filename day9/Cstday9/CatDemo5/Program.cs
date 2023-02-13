using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatDemo5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] tempArr = { "Tom","Anderson","Zoey","Alice","Bob"};
            List<string> strList = new List<string>(tempArr);
            strList.Add("John");
            strList.Remove("Tom");

            for (int i = 0; i < strList.Count; i++)
            {
                Console.WriteLine("each item is {0}",strList[i]);
                Console.ReadKey();
            }
            


        }
    }
}
