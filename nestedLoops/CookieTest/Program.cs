using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                

                string ingrediant = Console.ReadLine();

                for (int roll = 0; roll < times; )
                {
                    ingrediant = Console.ReadLine();
                    while (ingrediant == "Bake")
                    {

                       
                        Console.WriteLine($"Baking batch number {count}...");
                        break;
                        count++;
                    }

                }
            }
        }
    }
}
