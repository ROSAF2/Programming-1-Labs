using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Task5
{
    class Lab6Task5
    {
        static void Main()
        {
            Console.WriteLine("Please provide your marks:");
            Console.Write("\nAssignment mark 1: ");
            int mark1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nAssignment mark 2: ");
            int mark2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nTest mark: ");
            int mark3 = Convert.ToInt32(Console.ReadLine());

            int avgMark =(mark1+mark2+mark3)/3;

            if (avgMark >= 95) Console.WriteLine("\n\t\tYou've got a Merit");

            else
            {
                if (avgMark >= 80) Console.WriteLine("\n\t\tYou Pass");
                else Console.WriteLine("\n\t\tYou have Failed!");
            }
            Console.ReadLine();
        }
    }
}
