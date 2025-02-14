//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ASCENDION_OOPS
//{
//    public class Emp
//    {

//        int id;
//        string name;
//        double salary;
//        public Emp()
//        {
//            Console.WriteLine("emp constructor call");
//            id = 0;
//            name = "not given";
//            salary = 0;
//        }

//        public int Id { get { return id; } set { id = value; } }

//        public string Name { get { return name; } set { name = value; } }

//        public double Salary { get { return salary; } set { salary = value; } }

//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ASCENDION_OOPS
//{
//    public class Emp
//    {

//        int id;
//        string name;
//        double salary;
//        public Emp()
//        {
//            Console.WriteLine("emp constructor call");
//            id = 0;
//            name = "not given";
//            salary = 0;
//        }

//        public int Id { get { return id; } set { id = value; } }

//        public string Name { get { 

//                if(name == "invalid name")
//                {
//                    Console.WriteLine("name must have 6 characters");
//                }
//                return name;

//            } set {

//                if (value.Length <= 6)
//                {
//                    name = "invalid name";
//                }
//                else
//                {
//                    name = value;

//                }
//                } }

//               public double Salary { get { return salary; } set { salary = value; } }




//    }

//}


//READONLY
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCENDION_OOPS
{
    public class Emp
    {

        int id;
        string name;
        double salary;
        public Emp()
        {
            Console.WriteLine("emp constructor call");
            id = 0;
            name = "not given";
            salary = 0;
        }

        public int Id { get { return id; } set { id = value; } }

        public string Name
        {
            get
            {

                if (name == "invalid name")
                {
                    Console.WriteLine("name must have 6 characters");
                }
                return name;

            }
            set
            {

                if (value.Length <= 6)
                {
                    name = "invalid name";
                }
                else
                {
                    name = value;

                }
            }
        }

        //public double Salary { get { return salary; }  }




    }

}


