using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product product = new Product()
            //{
            //    PId = 1,
            //    PName = "fruits",
            //    PPrice = 500,
            //    MfgDate = new DateTime(day: 12, month: 1, year: 2025)
            //};

            //Console.WriteLine("product details:");

            //Console.WriteLine("pid:" + product.PId);

            //Console.WriteLine("pname: " + product.PName);

            //Console.WriteLine("pprice: " + product.PPrice);

            //Console.WriteLine("pMfg: " + product.MfgDate);

            //==============================================================?

            Product product1 = new Product();

            Console.WriteLine("enter pid");
            product1.PId = int.Parse(Console.ReadLine());

            Console.WriteLine("enter pname");
            product1.PName = Console.ReadLine();

            Console.WriteLine("enter pprice");
            product1.PPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("enter mfgdate");
            product1.MfgDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("product 1 details:");

            Console.WriteLine("pid:" + product1.PId);

            Console.WriteLine("pname: " + product1.PName);

            Console.WriteLine("pprice: " + product1.PPrice);

            Console.WriteLine("pMfg: " + product1.MfgDate);

            Product product2 = new Product()
            {
                PId = 1,
                PName = "fruits",
                PPrice = 500,
                MfgDate = new DateTime(day: 12, month: 1, year: 2025)
            };


            Console.WriteLine("product 2 details:");

            Console.WriteLine("pid:" + product2.PId);

            Console.WriteLine("pname: " + product2.PName);

            Console.WriteLine("pprice: " + product2.PPrice);

            Console.WriteLine("pMfg: " + product2.MfgDate);

            Console.ReadKey();

        }
    }
}
