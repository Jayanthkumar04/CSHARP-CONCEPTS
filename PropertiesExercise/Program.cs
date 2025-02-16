using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee();

            Console.WriteLine("Enter Id");
            emp1.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name");
            emp1.Name = Console.ReadLine();

            Console.WriteLine("Enter salary");
             emp1.Salary = double.Parse(Console.ReadLine());

            if (emp1.Salary == 0)
            {
                Console.WriteLine("invalid salary broo");
            }
            else
            {

                Console.WriteLine("Details");
                Console.WriteLine($"Id:{emp1.Id} Name:{emp1.Name} Salary{emp1.Salary}");
                Console.WriteLine("no of emp: " + Employee.noOfEmp);
            }


            Employee emp2 = new Employee();

            Console.WriteLine("Enter Id");
            emp2.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name");
            emp2.Name = Console.ReadLine();

            Console.WriteLine("Enter salary");
            emp2.Salary = double.Parse(Console.ReadLine());

            if (emp2.Salary == 0)
            {
                Console.WriteLine("invalid salary broo");
            }
            else
            {

                Console.WriteLine("Details");
                Console.WriteLine($"Id:{emp2.Id} Name:{emp2.Name} Salary{emp2.Salary}");
                Console.WriteLine("no of emp: " + Employee.noOfEmp);
            }


            Employee emp3 = new Employee();

            Console.WriteLine("Enter Id");
            emp3.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name");
            emp3.Name = Console.ReadLine();

            Console.WriteLine("Enter salary");
            emp3.Salary = double.Parse(Console.ReadLine());

            if (emp3.Salary == 0)
            {
                Console.WriteLine("invalid salary broo");
            }
            else
            {

                Console.WriteLine("Details");
                Console.WriteLine($"Id:{emp3.Id} Name:{emp3.Name} Salary{emp3.Salary}");
                Console.WriteLine("no of emp: " + Employee.noOfEmp);
            }


            Console.ReadKey();



        }
    }
}
