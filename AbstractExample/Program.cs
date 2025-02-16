using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OurDrive ourDrive = new OurDrive();

            ourDrive.Display();

            Console.WriteLine("our interface property "+ourDrive.MyProperty);

            Console.ReadKey();
        }
    }
}
