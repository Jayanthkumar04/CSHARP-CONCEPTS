using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBigExample
{
    public class SavingsAccount : IAccount
    {
        double savingBal;

        public SavingsAccount()
        {
            savingBal = 25000.75;
        }
        public double Balance => savingBal;

        public double Deposit(double amount)
        {
            savingBal += amount;
            Console.WriteLine("transaction success");
            return savingBal;
        }

        public double WithDraw(double amount)
        {
        
            if(savingBal >= amount)
            {
                if(savingBal-amount >= 10000)
                {
                    savingBal -= amount;
                    Console.WriteLine("transactin success");
                }
                else
                {
                    Console.WriteLine("you must have max 10k in your acc");
                    Console.WriteLine("transactoin failed");
                }
            }
            else
            {
                Console.WriteLine("insufficient Amount in Account");
            }

            return savingBal;

        }
    }
}
