using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab24Task4
{
    public struct ParticipantData
    {
        public string firstName;
        public string lastName;
        public string interest;
    }
    class Lab24Task4
    {
        static void Main(string[] args)
        {
            ParticipantData[] array = new ParticipantData[30];

            //Reading from file into my array
            StreamReader sr = new StreamReader("millionaire.txt");

            for (int i = 0; i < array.Length; i++)
            {
                array[i].firstName = sr.ReadLine();
                array[i].lastName = sr.ReadLine();
                array[i].interest = sr.ReadLine();
            }
            sr.Close();

            //Bubble Sort

            ParticipantData swap;

            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j+1].lastName.CompareTo(array[j].lastName) < 0)
                    {
                        swap = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = swap;
                    }
                }
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].lastName.PadRight(25) + array[i].firstName.PadRight(15) + array[i].interest.PadRight(15));
            }

            Console.ReadLine();
        }
    }
}
