using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21Task4
{
    public struct memberDetails
    {
        public string firstName;
        public string lastName;
        public string phone;
    }
    class Lab21Task4
    {
        static void Main()
        {
            int numberOfMembers = 3;
            memberDetails[] classMember = new memberDetails[numberOfMembers];

            Console.WriteLine("Enter the class members' information\n");

            for (int i = 0; i < numberOfMembers; i++)
            {
                Console.WriteLine("\nMember number {0}",i+1);
                Console.Write("\nFirst name: ");
                classMember[i].firstName = Console.ReadLine();
                Console.Write("\nLast name: ");
                classMember[i].lastName = Console.ReadLine();
                Console.Write("\nPhone: ");
                classMember[i].phone = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 0; i < numberOfMembers; i++)
            {
                Console.WriteLine("\t\t\t" + classMember[i].firstName.PadRight(15) + classMember[i].lastName.PadRight(15) + classMember[i].phone);
            }


            Console.ReadLine();
        }
    }
}
