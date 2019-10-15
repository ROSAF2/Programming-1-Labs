using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Task4
{
    class Lab13Task4
    {
        static void Main()
        {
            string line, lineU, lineL;
            int U = 0, L = 0, S = 0;
            string special = "1234567890!@#$%^&*()-={};':\"[\\`~<>?/+]_";
            bool condition = false;

            Console.Write("Enter a line of text: ");
            line = Console.ReadLine();

            lineU = line.ToUpper();
            lineL = line.ToLower();

            for (int i = 0; i < line.Length; i++)
            {
                for (int j = 0; j < special.Length; j++)
                {
                    if (line[i] == special[j]) condition = true;
                }
                if (condition) { S++; condition = false; }
                else if (line[i] == ' ') ;
                else if (line[i] == lineU[i]) U++;
                else if (line[i] == lineL[i]) L++;
            }
            Console.WriteLine($"\n{U} UPPER CASE LETTERS\n\n{L} lower case letters\n\n{S} special characters");


            Console.ReadLine();

        }
    }
}
