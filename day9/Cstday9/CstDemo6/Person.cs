using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo6
{
    public class Person
    {
        //private string _name;

        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}

        private string _eyecolor;

        public string Eyecolor
        {
            get { return _eyecolor; }
            set { _eyecolor = value; }
        }

        public string Name { get; set; } // 自动属性

        //public int MyProperty { get; private set; }

    }
}
