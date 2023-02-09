using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo2
{
    class Staff:Person
    {

        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public new void Speak() // hide parent same name method.
        {
            Console.WriteLine( "I am talking on class of staff.");
        }
    }
}
