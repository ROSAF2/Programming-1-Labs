using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Task4
{
    class Lab7Task4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            const double AUD = 0.8085, USD = 0.8272, GBP = 0.5457, JPY = 76.23, EUR = 0.692;
            double AUDF, USDF, GBPF, JPYF, EURF;
            char e = '€';

            Console.Write("How much money would you like to change?: ");
            int NZD = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Press 1 for Australina Dollars");
            Console.WriteLine("Press 2 for US Dollars");
            Console.WriteLine("Press 3 for English Pounds");
            Console.WriteLine("Press 4 for Japanese Yen");
            Console.WriteLine("Press 5 for Euros");
            Console.WriteLine();

            int input= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            AUDF = AUD * NZD;
            USDF = USD * NZD;
            GBPF = GBP * NZD;
            JPYF = JPY * NZD;
            EURF = EUR * NZD;

            switch (input)
            {
                case 1:
                    Console.WriteLine("That is:");
                    Console.WriteLine($"{AUDF:C2} AUD");
                    break;
                case 2:
                    Console.WriteLine($"{USDF:C2} USD");
                    break;
                case 3:
                    Console.WriteLine($"£{GBPF:F2} GBP");
                    break;
                case 4:
                    Console.WriteLine($"¥{JPYF:F2} JPY");
                    break;
                case 5:
                    Console.WriteLine($"{e}{EURF} EUR");
                    break;
            }
            

            Console.ReadLine();

        }
    }
}
