using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConffAppInterfaceEx2
{
    public class OurClass : IOne, ITwo
    {
        

        //public void Display()
        //{

        //    Console.WriteLine("display method of interface one");
        //}

        //public void Welcome(string name)
        //{
        //    Console.WriteLine("welcome to interface two mr.\\ms." + name);
        //}

        void IOne.Display()
        {
            Console.WriteLine("im coming fro minterface one");
        }

        void ITwo.Display()
        {
            Console.WriteLine("display of interface two");
        }

    }
}
