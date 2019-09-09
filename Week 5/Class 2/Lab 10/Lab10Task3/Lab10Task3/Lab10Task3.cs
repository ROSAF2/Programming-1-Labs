using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Task3
{
    class Lab10Task3
    {
        static void Main()
        {
            int result;
            Console.Write("Please enter the number for the multiplication table you want to use: ");
            int user = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i < 13; i++)
            {
                result = user * i;
                Console.WriteLine("{0} * {1} = {2}",user,i,result);
            }

            Console.ReadLine();
        }
    }
}
