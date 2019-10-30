using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;

            Console.WriteLine("Date: {0}",date.Date);
            Console.WriteLine("Day: {0}",date.Day);
            Console.WriteLine("Day of the Week: {0}",date.DayOfWeek);
            Console.WriteLine("Day of the year: {0}",date.DayOfYear);
            Console.WriteLine("Hour: {0}",date.Hour);
            Console.WriteLine("Kind: {0}",date.Kind);
            Console.WriteLine("Milisecond: {0}",date.Millisecond);
            Console.WriteLine("Minute {0}: ",date.Minute);
            Console.WriteLine("Month {0}: ",date.Month);
            Console.WriteLine("Second {0}:",date.Second);
            Console.WriteLine("Ticks {0}:",date.Ticks);
            Console.WriteLine("Time of the Day: {0}",date.TimeOfDay);
            Console.WriteLine("UtcNow: {0}");
            Console.WriteLine("Year: {0}",date.Year);

            Console.ReadLine();
        }
    }
}
