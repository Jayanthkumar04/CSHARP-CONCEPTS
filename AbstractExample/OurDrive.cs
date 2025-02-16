using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    internal class OurDrive:IOurInterface
    {

        int ourField;

        public OurDrive()
        {
            ourField = 12;
        }

        public int MyProperty { get => ourField; set => ourField = value; }

        public void Display()
        {
            Console.WriteLine("display method of ourinterface");
        }


    }
}
