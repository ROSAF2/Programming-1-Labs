using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15Task6
{
    class Lab15Task6
    {
        static void Main()
        {
            Random rand = new Random();
            int va = rand.Next(1, 41);
            int[] arr = new int[6];

            Console.WriteLine("\t\t\tLotto Problem\n");
            
            for (int i = 0; i < 6; i++)
            {
                while (va == arr[0] || va == arr[1]|| va == arr[2] || va == arr[3]|| va == arr[4] || va == arr[5])
                {
                    va = rand.Next(1, 41);
                }
                arr[i] = va;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i + 1}.- {arr[i]}");
            }

            Console.ReadLine();
        }
    }
}
