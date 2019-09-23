using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14Task6
{
    class Lab14Task6
    {
        static void Main(string[] args)
        {
            Console.Write("Please provide a birth date in the following form \"dd/mm/yyyy\": ");
            string date = Console.ReadLine();

            //Using IndexOf to get the index of the forward slashes
            int firstSlash = date.IndexOf('/');
            int secondSlash = date.IndexOf('/',firstSlash+1);

            //Extracting the required information by taking the slashes as reference points
            string stringDay = date.Substring(0, firstSlash);
            string stringMonth = date.Substring(firstSlash + 1, secondSlash - (firstSlash + 1));
            string stringYear = date.Substring(secondSlash+1);

            //Converting and storing the extracted strings
            int year = Convert.ToInt32(stringYear);
            int month = Convert.ToInt32(stringMonth);
            int day = Convert.ToInt32(stringDay);

            Console.WriteLine();
            //Printing them on screen
            Console.WriteLine(day);
            Console.WriteLine(month);
            Console.WriteLine(year);

            Console.ReadLine();
        }
    }
}
