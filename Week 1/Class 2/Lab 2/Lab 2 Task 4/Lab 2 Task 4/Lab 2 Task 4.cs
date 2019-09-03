using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Task_4
{
    class Program
    {
        static void Main()
        {
            string X;
            int count;

            //

            Console.WriteLine("Input Value: ");
            X = Console.ReadLine();
            count = Convert.ToInt32(X);

            //

            count = count + 1;

            //
            Console.WriteLine(count);
            Console.Read();
        }
    }
}
