using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBigExample
{
    public class ATM
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to ATM");
            Console.WriteLine("choose Account Type:\n 1) savings \n 2)Current");

            IAccount account;

            int acType = int.Parse(Console.ReadLine());
            switch (acType)
            {

                case 1:
                    {
                        account = new SavingsAccount();
                        break;
                    }

                case 2:
                    {
                        account = new CurrentAccount();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid choice");
                        return;
                    }
            
            }

            Console.WriteLine("choose Transaction :\n 1)balance \n2)deposit\n 3)withdraw");

            int op = int.Parse(Console.ReadLine());

            switch(op)
            {
                case 1:
                    {
                        Console.WriteLine("acc balance:\t"+account.Balance);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("enter amount to be deposit");
                        Console.WriteLine("balance after transaction:" +
                            " \t"+account.Deposit(double.Parse(Console.ReadLine())));
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("enter amount to be withdrawn");
                        Console.WriteLine("balance after transaction:" +
                            " \t" + account.WithDraw(double.Parse(Console.ReadLine())));
                        break;

                    }

                default:
                    {
                        Console.WriteLine("Invalid Choice");
                        break;
                    }
            }


        }
    }
}
