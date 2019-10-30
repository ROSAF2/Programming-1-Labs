using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25Task2
{
    class Program
    {
        static void Main()
        {
            DateTime now = DateTime.Now;

            Console.Write("Enter a birthdate (dd/mm/yy): ");
            string birthdate = Console.ReadLine();

            string[] birthdateSplit = birthdate.Split('/');

            int day = Convert.ToInt32(birthdateSplit[0]);
            int month = Convert.ToInt32(birthdateSplit[1]);
            int year = Convert.ToInt32(birthdateSplit[2]);

            DateTime date = new DateTime(now.Year, month, day);

            if (date > now)
            {

            }
            else
            {

            }


            Console.ReadLine();
        }
    }
}
