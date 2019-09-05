using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15Task1
{
    class Lab15Task1
    {
        static void Main()
        {

            Random rand = new Random();
            int va = rand.Next(1, 41);
            int[] arr = new int[6];
            int[] arr2 = new int[];

            Console.WriteLine("\t\t\tLotto Problem\n");



            for (int i = 0; i < 6; i++)
            {
                arr[i] = va;
                while (va == arr[i])
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
