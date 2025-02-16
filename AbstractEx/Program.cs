using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            OurDriveClass obj = new OurDriveClass();
            obj.Welcome("Sam");

            obj.Display();
            Console.WriteLine(obj.ourAbProp);

            Console.WriteLine(obj.AbProp);
            
            Console.ReadKey();

        }
    }
}
