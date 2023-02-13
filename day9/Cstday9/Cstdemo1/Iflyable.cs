using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    public interface Iflyable
    {
        //int Mytest { get; set; } // you can define property.

        void Flying(); // interface method (does not have body)
        // void Run();

        int Add();
        void Speaking();
    }
}
