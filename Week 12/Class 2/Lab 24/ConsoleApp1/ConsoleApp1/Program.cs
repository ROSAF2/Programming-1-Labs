using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public struct ContestantDetails
    {
        public string lastName;
        public string firstName;
        public string interest;
    }
    class Program
    {
        public static void WritingToFile(ContestantDetails[] array, string filePath)
        {
            StreamWriter sw = new StreamWriter(filePath);
            for (int i = 0; i < array.Length; i++)
            {
                sw.WriteLine(array[i].firstName);
                sw.WriteLine(array[i].lastName);
                sw.WriteLine(array[i].interest);
            }
            sw.Close();
        }
        static void Main(string[] args)
        {
            ContestantDetails[] arrayOfContestants = new ContestantDetails[30];
            
            WritingToFile(arrayOfContestants,"sometihng");
            Console.ReadLine();
        }
    }
}
