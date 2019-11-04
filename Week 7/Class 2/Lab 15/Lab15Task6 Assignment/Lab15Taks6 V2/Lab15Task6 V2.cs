using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15Taks6_V2
{
    public struct name
    {
        public string fname;
    }
    class Program
    {
        static void Main()
        {
            name[] Lastname = new name[30];

            Random rand = new Random();
            int[] finalists = new int[10];

            for (int i = 0; i < finalists.Length; i++)
            {
                finalists[i] = -1;
            }
            int lot = rand.Next(0, 30);
            for (int i = 0; i < finalists.Length; i++)
            {
                while (finalists.Contains(lot))
                {
                    lot = rand.Next(0,30);
                }
                finalists[i] = lot;
            }
            //Ten Finalists
            for (int i = 0; i < finalists.Length; i++)
            {
                Console.WriteLine(Lastname[finalists[i]].fname);

            }
        }
    }
}
