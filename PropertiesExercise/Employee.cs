using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExercise
{
    public class Employee
    {

        public int id;

        public string name;

        public double salary;

        public static int noOfEmp=0;
        public Employee()
        {
            Console.WriteLine("emp constructor call");
            id = 0;
            name = "not given";
            salary = 0;
            noOfEmp++;
           
        }

        public int NoOfEmp
        {
            get { return noOfEmp; }  

        }

        public int Id { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }

        public double Salary { get { return salary; } set {

                if (value < 10000 || value > 100000)
                {
                    salary = 0;
                }
                else
                {
                    salary = value;
                }
            
            } }


    }
}
