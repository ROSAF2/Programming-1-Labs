using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18Task4
{
    class Lab18Task4
    {
        public static void Method1()
        {
            Console.Clear();
            Console.WriteLine("This is Method 1");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Method2()
        {
            Console.Clear();
            Console.WriteLine("This is Method 2");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Method3()
        {
            Console.Clear();
            Console.WriteLine("This is Method 3");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Method4()
        {
            Console.Clear();
            Console.WriteLine("This is Method 4");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Invalid()
        {
            Console.Clear();
            Console.WriteLine("Please enter a valid option.");
            Console.ReadLine();
            Console.Clear();
        }

        static void Main()
        {
            int input;
            do
            {
                Console.WriteLine("The menu options are: ");
                Console.Write("\n1".PadRight(10)); Console.Write("Task 1");
                Console.Write("\n2".PadRight(10)); Console.Write("Task 2");
                Console.Write("\n3".PadRight(10)); Console.Write("Task 3");
                Console.Write("\n4".PadRight(10)); Console.Write("Task 4");
                Console.Write("\n0".PadRight(10)); Console.Write("Exit menu system");

                Console.Write("\n\nSelect an option: ");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 0:
                        break;
                    case 1:
                        Method1();
                        break;
                    case 2:
                        Method2();
                        break;
                    case 3:
                        Method3();
                        break;
                    case 4:
                        Method4();
                        break;
                    default:
                        Invalid();
                        break;
                }

            } while (input != 0);

            Console.WriteLine("\nExiting the program");

            Console.ReadLine();
        }
    }
}
