using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBigExample
{
    public class CurrentAccount : IAccount
    {
        double currentBal;

        public CurrentAccount()
        {
            currentBal = 56000.50;
        }
        public double Balance => currentBal;

        public double Deposit(double amount)
        {
            currentBal += amount;
            return currentBal;
        }

        public double WithDraw(double amount)
        {
            if(currentBal >= amount)
            {
                currentBal -= amount;
                Console.WriteLine("Transaction success");
            }
            else
            {
                Console.WriteLine("No Sufficient Balance to do the transaction");
                Console.WriteLine("Transaction failed");
            }

            return currentBal;
        }
    }
}
