using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingInCSharp
{
    public class Emp
    {
        int id;
        string name;
        string qual;

        public Emp()
        {
            Console.WriteLine("emp constructor");

            id = -1;
            name = "not given";
            qual = "not given";
        }

        public virtual void Register()
        {
            Console.WriteLine("enter Id");
            id=int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter qualification");
            qual= Console.ReadLine();   

        }

        public virtual void Display()
        {
            Console.WriteLine("Id: "+id);
            Console.WriteLine("Name: "+name);
            Console.WriteLine("qualification: "+qual);
        }



    }
}
