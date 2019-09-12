using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Exam2
{
    class Lab16Exam2
    {
        static void Main()
        {
            int counter=0;
            string pass1, pass2;

            Console.WriteLine("Set Password Program");

            do
            {
                Console.Write("\nPlease enter your new password: ");
                pass1 = Console.ReadLine();

                Console.Write("\nPlease re-enter your new password: ");
                pass2 = Console.ReadLine();

                if (pass1 != pass2) Console.WriteLine("\nYour password has not been changed, please try again");

                counter++;

            } while (pass1!=pass2);

            Console.WriteLine("\nCongratulations, your password has been changed to {0}",pass1);

            if (counter == 1) Console.WriteLine("You changed your password on the first attempt");
            else Console.WriteLine("It took you {0} attempts to change your password",counter);


            Console.ReadLine();
        }
    }
}
