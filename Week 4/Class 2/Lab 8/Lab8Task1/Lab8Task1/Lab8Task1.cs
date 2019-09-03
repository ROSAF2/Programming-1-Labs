using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab8Task1
{
    class Lab8Task1
    {
        static void Main()
        {
           
            Random rand = new Random();

            int SurferDFS = rand.Next(20);
            int Shark = rand.Next(10); //Distance from surfer

            //Report
            Console.WriteLine($"Surfer is {SurferDFS}m from shore");
            Console.WriteLine($"Shark is {Shark}m from surfer");
            Thread.Sleep(1500);

            while (SurferDFS > 0 && Shark > 0)
            {

                SurferDFS=SurferDFS- rand.Next(5);
                Shark = Shark - rand.Next(5);
                Console.WriteLine();
                Console.WriteLine($"Surfer is {SurferDFS}m from shore");
                Console.WriteLine($"Shark is {Shark}m from surfer");
                Thread.Sleep(1500);
            }

            if (SurferDFS <= 0) Console.WriteLine("\n\tSurfer made it!");
            else Console.WriteLine("\n\tShark ate the Surfer");


            Console.ReadLine();
        }
    }
}
