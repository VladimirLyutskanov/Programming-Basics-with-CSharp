using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string kind = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns=int.Parse (Console.ReadLine());
            double price = 0;
            double ticket = 0;

            if (kind =="Premiere")
            {
                ticket = 12.00;
            }
            else if (kind == "Normal")
            {
                ticket = 7.50;
            }
            else if (kind == "Discount")
            {
                ticket = 5.00;
            }
            price = ticket * rows * columns;
            Console.WriteLine($"{price:f2}");

        }
    }
}
