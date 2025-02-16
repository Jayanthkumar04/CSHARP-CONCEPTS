using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingInCSharp
{
    public class Dev:Emp
    {
        string project;
        string domain;
        public Dev()
        {
            Console.WriteLine("Developer Constructor");
            project = "not given";
            domain = "not given";
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("projects :"+project);
            Console.WriteLine("domain :"+domain);
        }

        public override void Register()
        {
            base.Register();
            Console.WriteLine("enter domain");
            domain = Console.ReadLine();

            Console.WriteLine("enter project");
            project = Console.ReadLine();
        }

    }
}
