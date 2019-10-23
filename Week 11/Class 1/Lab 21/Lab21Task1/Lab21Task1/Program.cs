using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21Task1
{
    public struct IcecreamData
    {
        public string name;
        public string manufacturer;
        public string flavour;
        public int cost;
        public int inStock;
    }
    class Program
    {
        static void Main()
        {
            IcecreamData icecream;
            Console.Write("Enter the name of the icecream: ");
            icecream.name = Console.ReadLine();
            Console.Write("Enter the manufacturer: ");
            icecream.manufacturer = Console.ReadLine();
            Console.Write("Enter the flavour: ");
            icecream.flavour = Console.ReadLine();
            Console.Write("Enter the cost:");
            icecream.cost = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of icecreams in stock: ");
            icecream.inStock = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe details of the icecreame are: ");
            Console.WriteLine("Name: "+icecream.name);
            Console.WriteLine("Manufacturer: " + icecream.manufacturer);
            Console.WriteLine("Flavour: " + icecream.flavour);
            Console.WriteLine("Cost: " + icecream.cost);
            Console.WriteLine("Stock: " + icecream.inStock);



            Console.ReadLine();
        }
    }
}
