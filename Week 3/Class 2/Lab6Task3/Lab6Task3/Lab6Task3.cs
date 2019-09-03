using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Task3
{
    class Lab6Task3
    {
        static void Main()
        {
            Console.WriteLine("\nPlease enter your gender, use M or F");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nWhich course are you in?");
            string course = Console.ReadLine();

            if (course == "BIT")
            {
                if (gender == 'M') Console.WriteLine("\nBIT men's t-shirt $25");
                else Console.WriteLine("\nBIT women's t-shirt $30");
            }
            else Console.WriteLine("\nPolytec T-shirt $20");

            Console.ReadLine();
        }
    }
}
