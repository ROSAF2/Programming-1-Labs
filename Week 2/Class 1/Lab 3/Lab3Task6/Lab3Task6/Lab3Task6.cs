using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task6
{
    class Lab3Task6
    {
        static void Main()
        {
            string totalHoursS;
            int totalHoursI, days, hours;

            Console.Write("Please input a whole number of hours: ");
            totalHoursS = Console.ReadLine();
            totalHoursI = Convert.ToInt32(totalHoursS);

            days = totalHoursI / 24;
            hours = totalHoursI % 24;
            Console.WriteLine();
            Console.WriteLine($"That is {days} days and {hours} hours.");
            Console.ReadLine();
        }
    }
}
