using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15Taks6_V2
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int[] arr = new int[15];
            int va = rand.Next(1, 41);

            Console.WriteLine("\t\t\tLotto Problem\n");

            for (int i = 0; i < arr.Length; i++)
            {
                while (arr.Contains(va))
                {
                    va = rand.Next(1, 41);
                }
                arr[i] = va;
                Console.WriteLine($"{i + 1}.- {arr[i]}");
            }
            Console.ReadLine();
        }
    }
}
