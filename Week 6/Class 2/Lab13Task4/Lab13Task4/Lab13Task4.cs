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
            /*
            string name = "zebra";

            name = name.Replace('a', 'o');

            Console.WriteLine(name);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.Contains("bra"));
            Console.WriteLine(name.ElementAt(0));
            Console.WriteLine(name.Equals("Zebra"));
            Console.WriteLine(name.IndexOf('a'));
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());

            foreach (char i in name)
            {
                Console.WriteLine(i);

            }
            */

            string[] songArray = new string[7];
            int U, L, O;

            Console.WriteLine("Please input a line of text\n");

            if ()

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Title {i + 1}: ");
                songArray[i] = Console.ReadLine();

                if (songArray[i] == "")
                    break;
                Console.WriteLine();
            }



            
            Console.ReadLine();






            Console.ReadLine();

        }
    }
}
