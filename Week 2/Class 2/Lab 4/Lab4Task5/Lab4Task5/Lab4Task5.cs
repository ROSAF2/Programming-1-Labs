using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task5
{
    class Lab4Task5
    {
        static void Main()
        {
            const double aud = 0.8085, usd=0.8272, gdp=0.5457, jpy=76.23, eur=0.6297;
            double NZD, AUD, USD, GBP, JPY, EUR;
            char e = '€';


            Console.WriteLine();

            // Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Please provide the amount of New Zealand dollars you want to convert: ");
            NZD = Convert.ToDouble(Console.ReadLine());

            AUD = aud * NZD;
            USD = usd * NZD;
            GBP = gdp * NZD;
            JPY = jpy * NZD;
            EUR = eur * NZD;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Australina Dollar: ${AUD} AUD          American Dollar: ${USD} USD           English Pound: \u00A3{GBP} GBP");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Japanese Yen:      ¥{JPY} JPY          Euro:            {e}{EUR} EUR");

            Console.ReadLine();
        }
    }
}
