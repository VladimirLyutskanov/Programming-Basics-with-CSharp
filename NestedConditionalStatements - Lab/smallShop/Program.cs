using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (productName == "coffee")
                {
                    Console.WriteLine($"{quantity * 0.50}");
                }
                else if (productName == "water")
                {
                    Console.WriteLine($"{quantity * 0.80}");
                }
                else if (productName == "beer")
                {
                    Console.WriteLine($"{ quantity * 1.20}");
                }
                else if (productName == "sweets")
                {
                    Console.WriteLine($"{quantity * 1.45}");
                }
                else if (productName == "peanuts")
                {
                    Console.WriteLine($"{quantity * 1.60}");
                }
            }
            if (city == "Plovdiv")
            {
                if (productName == "coffee")
                {
                    Console.WriteLine($"{quantity * 0.40}");
                }
                else if (productName == "water")
                {
                    Console.WriteLine($"{quantity * 0.70}");
                }
                else if (productName == "beer")
                {
                    Console.WriteLine($"{ quantity * 1.15}");
                }
                else if (productName == "sweets")
                {
                    Console.WriteLine($"{quantity * 1.30}");
                }
                else if (productName == "peanuts")
                {
                    Console.WriteLine($"{quantity * 1.50}");
                }
            }
            if (city == "Varna")
            {
                if (productName == "coffee")
                {
                    Console.WriteLine($"{quantity * 0.45}");
                }
                else if (productName == "water")
                {
                    Console.WriteLine($"{quantity * 0.70}");
                }
                else if (productName == "beer")
                {
                    Console.WriteLine($"{ quantity * 1.10}");
                }
                else if (productName == "sweets")
                {
                    Console.WriteLine($"{quantity * 1.35}");
                }
                else if (productName == "peanuts")
                {
                    Console.WriteLine($"{quantity * 1.55}");
                }
            }
        }

    }
}

