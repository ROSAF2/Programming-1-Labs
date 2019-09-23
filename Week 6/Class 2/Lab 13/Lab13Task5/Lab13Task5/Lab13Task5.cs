using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Task5
{
    class Lab13Task5
    {
        static void Main()
        {
            Console.Write("Enter line: ");
            string line = Console.ReadLine();

            string[] array = line.Split(' ');

            string noSpaces = "";

            for (int i = 0; i < array.Length; i++)
            {
                noSpaces = noSpaces + array[i];
            }

            string noSpacesUp = noSpaces.ToUpper();
            string noSpacesLo = noSpaces.ToLower();
            int upper = 0, lower = 0;

            for (int i = 0; i < noSpaces.Length; i++)
            {
                if (noSpaces[i] == noSpacesUp[i]) upper++;
                else if (noSpaces[i] == noSpacesLo[i]) lower++;
            }

            //Console.WriteLine(noSpacesUp);
            //Console.WriteLine(noSpacesLo);
            Console.WriteLine("Upper: {0}", upper);
            Console.WriteLine("Lower: {0}", lower);

            //ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz


            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            int[] counter = new int[characters.Length];

            for (int i = 0; i < noSpaces.Length; i++)
            {
                for (int j = 0; j < characters.Length; j++)
                {
                    if (noSpaces[i] == characters[j]) counter[j]++;
                }
            }

            for (int i = 0; i < characters.Length; i++)
            {
                Console.WriteLine("{0}{1}", characters[i], counter[i]);
            }

            Console.ReadLine();
        }
    }
}
