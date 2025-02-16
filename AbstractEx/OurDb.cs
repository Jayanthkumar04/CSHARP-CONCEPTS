using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEx
{
    public abstract class ourAb
    {
        int pFeild;

        public ourAb()
        {
            Console.WriteLine("Constructor of Abstract class");
            pFeild = 0;
        }
        public abstract void Display();
        public void Welcome(String name)
        {
            Console.WriteLine("Welcome to abstract class mr. " + name);
        }

        public abstract string ourAbProp { get; set; }
        public int AbProp { get { return pFeild; } set { pFeild = value; } }


    }
}
