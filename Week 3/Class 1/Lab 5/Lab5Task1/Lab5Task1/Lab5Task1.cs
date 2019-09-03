using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Task1
{
    class Lab5Task1
    {
        static void Main()
        {
            const double INTEREST = 0.03, FEE=20;
            double balance;

            Console.WriteLine("\nPlease provide your overdraft balance:");
            balance = double.Parse(Console.ReadLine());

            if (balance >= 0) balance = balance + balance * INTEREST;
            else
            {
                balance = balance - FEE;
                Console.WriteLine("\t\t\t\t\t   WARNING! \n\n\t\t\tA $20.00 fee has been charged from your balance");    
            }
            Console.WriteLine($"\n\n \t\t\t\tYour yearly balance would be ${balance:F2}");
            Console.ReadLine();
        }
    }
}
