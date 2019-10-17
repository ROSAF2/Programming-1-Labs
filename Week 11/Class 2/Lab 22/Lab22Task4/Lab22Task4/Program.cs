using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab22Task4
{
    public struct Student
    {
        public string name;
        public string address;
        public int team;
    }
    class Program
    {
        public static void Method1(Student[] array)
        {
            StreamReader sr = new StreamReader("names2.txt");
            Random rand = new Random();
            
            for (int i = 0; i < 30; i++)
            {
                array[i].name = sr.ReadLine();
                array[i].address = "Dunedin";
                array[i].team = rand.Next(1, 5);
            }
            sr.Close();
        }

        public static void Method2(Student[] array)
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(array[i].name.PadRight(25)+ array[i].address.PadRight(10)+ array[i].team.ToString().PadLeft(10));
            }
        }
        public static void Method3(Student[] array)
        {
            StreamWriter sw = new StreamWriter("ourClass.txt");

            for (int i = 0; i < 30; i++)
            {
                sw.WriteLine(array[i].name.PadRight(25) + array[i].address.PadRight(10) + array[i].team.ToString().PadLeft(10));
            }
            sw.Close();
        }
        static void Main(string[] args)
        {
            Student[] info = new Student[30];

            Method1(info);
            Method2(info);
            Method3(info);



            Console.ReadLine();

        }
    }
}
