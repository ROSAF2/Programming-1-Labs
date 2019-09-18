using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Task5
{
    class Lab10Task5
    {
        static void Main()
        {

            Random number = new Random();

            int i, dice;
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            int n5 = 0;
            int n6 = 0;


            for (i=1;i<6001;i++)
            {
                dice = number.Next(1,7);

                switch (dice)
                {
                    case 1:
                        n1++;
                        break;
                    case 2:
                        n2++;
                        break;
                    case 3:
                        n3++;
                        break;
                    case 4:
                        n4++;
                        break;
                    case 5:
                        n5++;
                        break;
                    case 6:          
                        n6++;
                        break;
                }


            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"\t\t\t\t\t _________________________________ ");
            Console.WriteLine($"\t\t\t\t\t| Side of the DICE | Times Thrown |");
            Console.WriteLine($"\t\t\t\t\t|        1         |     {n1}      |");
            Console.WriteLine($"\t\t\t\t\t|        2         |     {n2}      |");
            Console.WriteLine($"\t\t\t\t\t|        3         |     {n3}      |");
            Console.WriteLine($"\t\t\t\t\t|        4         |     {n4}      |");
            Console.WriteLine($"\t\t\t\t\t|        5         |     {n5}      |");
            Console.WriteLine($"\t\t\t\t\t|________6_________|_____{n6}______|");
            Console.ReadLine();
        }
    }
}
