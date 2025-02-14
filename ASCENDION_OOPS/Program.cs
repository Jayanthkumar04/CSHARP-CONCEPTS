using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCENDION_OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Emp emp = new Emp();

            Console.WriteLine("INITIAL VALUES: ");
            Console.WriteLine($"Id:{emp.Id} Name:{emp.Name} Salary{emp.Salary}");


            Console.WriteLine("Enter Id");
            emp.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name");
            emp.Name = Console.ReadLine();

            Console.WriteLine("Enter salary");
           // emp.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Details");
            Console.WriteLine($"Id:{emp.Id} Name:{emp.Name} Salary{emp.Salary}");

            Console.ReadKey();

            

           

        }
    }
}
