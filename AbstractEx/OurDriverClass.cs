using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEx
{
    class OurDriveClass : ourAb
    {
        string msg;
        public OurDriveClass()
        {
            msg = "I am from OurDriveClass";
        }
        public override string ourAbProp { get => msg; set => msg = value; }

        public override void Display()
        {
            Console.WriteLine("Display Method of OurDrive Class");
        }
    }
}
