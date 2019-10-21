using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp11
{
    class Program
    {
        static void ReadMethod()
        {
            StreamReader sr = new StreamReader("File.txt");
            
            string line = sr.ReadLine();
            Console.WriteLine(line);
            
            /*
            string everyline = sr.ReadToEnd();
            Console.WriteLine(everyline);
            */
            sr.Close();

        }

        static void WriteMethod()
        {
            StreamWriter sw = new StreamWriter("File2.txt");

            sw.WriteLine("67");
            sw.Close();
        }

        static void Main()
        {
            ReadMethod();
            //WriteMethod();
            //Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }
    }
}
