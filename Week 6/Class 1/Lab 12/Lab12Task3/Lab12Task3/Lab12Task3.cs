using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Task3
{
    class Lab12Task3
    {
        static void Main()
        {

            int[] marks = new int[5];
            int total=0;

            Console.WriteLine("Enter 5 marks\n");

            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
                total = total + marks[i];
            }

            double average = total / (double)marks.Length;

            Console.Write("\nMarks: ");

            foreach (int item in marks)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine("\nAverage: {0}",average);

            Console.ReadLine();
        }
    }
}
