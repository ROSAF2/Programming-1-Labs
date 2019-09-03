using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Task2
{
    class Lab5Task2
    {
        static void Main()
        {
            const double INTEREST = 0.03, FEE = 20;
            double balance;

            Console.WriteLine("\nPlease provide your overdraft balance:");
            balance = double.Parse(Console.ReadLine());

            if (balance >= 0) balance = balance + balance * INTEREST;
   
            Console.WriteLine($"\n\n \t\t\t\tYour yearly balance would be ${balance:F2}");
            Console.ReadLine();
        }
    }
}
