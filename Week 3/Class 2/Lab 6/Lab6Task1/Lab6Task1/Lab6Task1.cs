using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Task1
{
    class Lab6Task1
    {
        static void Main()
        {

           
            
            Console.WriteLine("\n\tPlease provide three numbers:\n");
            Console.Write("\t\t First: ");
            int nu1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\t\t Second: ");
            int nu2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\t\t Third: ");
            int nu3 = Convert.ToInt32(Console.ReadLine());
          
            if (nu1 == nu2 && nu1 == nu3) Console.WriteLine("\n\tThey are all the same.");

            else
            {
                if (nu1 < nu2 && nu2 < nu3)
                {
                    Console.WriteLine("\n\tThe numbers are in ascending order.");
                }

                else
                {
                    if (nu1 > nu2 && nu2 > nu3) Console.WriteLine("\n\tThe numbers are in descending order.");
                    else
                    {
                        if (nu1 == nu2 && nu1 != nu3) Console.WriteLine("\n\tThe numbers are not in order, the first and second are equal though.");
                        else
                        {
                            if (nu1 != nu2 && nu1 == nu3) Console.WriteLine("\n\tThe numbers are not in order, the first and third are equal though.");
                            else
                            {
                                if(nu1!=nu2&&nu2==nu3) Console.WriteLine("\n\tThe numbers are not in order, the second and third are equal though.");
                                else Console.WriteLine("\n\tThe numbers are not in order.");
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
