using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab23Task_1_7_
{
    public struct IcecreamStruct
    {
        public string name;
        public string manufacturer;
        public int decade;
    }
    class Program
    {
        public static void WriteToScreen(IcecreamStruct[] genericArray)
        {
            for (int i = 0; i < genericArray.Length; i++)
            {
                Console.WriteLine(genericArray[i].name.PadRight(20) + genericArray[i].manufacturer.PadRight(10) + genericArray[i].decade.ToString().PadLeft(8));
            }
        }
        static void Main(string[] args)
        {
            IcecreamStruct[] array = new IcecreamStruct[22];
            StreamReader sr = new StreamReader("icecream.txt");
            int i;

            for ( i=0; i < array.Length; i++)
            {
                array[i].name = sr.ReadLine();
                array[i].manufacturer = sr.ReadLine();
                array[i].decade = Convert.ToInt32(sr.ReadLine());
            }

            sr.Close();

            Array.Resize(ref array, array.Length+2);

            array[i].name = "IceCream_1";
            array[i].manufacturer = "SoCreative";
            array[i].decade = 2020;

            i++;

            array[i].name = "IceCream_2";
            array[i].manufacturer = "SoCreative";
            array[i].decade = 2020;

            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine(array[k].name.PadRight(20)+array[k].manufacturer.PadRight(10)+array[k].decade.ToString().PadLeft(8));
            }


            Console.WriteLine();

            // 4

            for (int k = 0; k < array.Length; k++)
            {
                if (array[k].manufacturer == "Streets")
                {
                    Console.WriteLine(array[k].name.PadRight(20) + array[k].manufacturer.PadRight(10) + array[k].decade.ToString().PadLeft(8));
                }
            }

            Console.WriteLine();

            // 5

            for (int k = 0; k < array.Length; k++)
            {
                if (array[k].decade == 1950)
                {
                    Console.WriteLine(array[k].name.PadRight(20) + array[k].manufacturer.PadRight(10) + array[k].decade.ToString().PadLeft(8));
                }
            }

            Console.Write("\nWhat icecream would you like to edit?: ");
            string answer = Console.ReadLine();

            for (int k = 0; k < array.Length; k++)
            {
                if (array[k].name == answer)
                {
                    array[k].manufacturer = "DeepSouth";
                }
            }

            Console.Clear();

            WriteToScreen(array);

            StreamWriter sw = new StreamWriter("icecream.txt");

            for (int k = 0; k < array.Length; k++)
            {
                sw.WriteLine(array[k].name);
                sw.WriteLine(array[k].manufacturer);
                sw.WriteLine(array[k].decade);
            }

            sw.Close();

            Console.ReadLine();
        }
    }
}
