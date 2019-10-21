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
        public string firstName;
        public string lastName;
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
                array[i].firstName = sr.ReadLine();
                array[i].lastName = sr.ReadLine();
                array[i].address = "Dunedin";
                array[i].team = rand.Next(1, 5);
            }
            sr.Close();
        }

        public static void Method2(Student[] array)
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(array[i].firstName.PadRight(12)+" "+ array[i].lastName.PadRight(21)+ array[i].address.PadRight(10)+ array[i].team.ToString().PadLeft(5));
            }
        }
        public static void Method3(Student[] array)
        {
            StreamWriter sw = new StreamWriter("ourClass.txt");

            for (int i = 0; i < 30; i++)
            {
                sw.WriteLine(array[i].firstName.PadRight(12) + " " + array[i].lastName.PadRight(21) + array[i].address.PadRight(10) + array[i].team.ToString().PadLeft(5));
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
