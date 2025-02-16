using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingInCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            Dev dev = new Dev();
            AppDev appdev = new AppDev();

            Console.WriteLine("enter employee details");
            emp.Register();
            Console.WriteLine("enter developer details");
            dev.Register();
            Console.WriteLine("enter app-developer details");
            appdev.Register();

            emp.Display();
            dev.Display();
            appdev.Display();

            Console.ReadKey();



        }
    }
}
