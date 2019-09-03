using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task2
{
    class Lab4Task2
    {
        static void Main()
        {
            const double adultTicket = 16.5, childrenTicket = 10.5;
            int aTickets, cTickets;
            double total;

            Console.WriteLine("\nHow many adult tickets will you buy?: \n");
            aTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHow many children tickets?: \n");
            cTickets = Convert.ToInt32(Console.ReadLine());

            total = aTickets*adultTicket+cTickets*childrenTicket;

            Console.WriteLine($"\nThat's a total of: {total:C2} \n");
            Console.ReadLine();
        }
    }
}
