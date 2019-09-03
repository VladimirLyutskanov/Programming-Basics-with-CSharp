using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skiNew
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rate = Console.ReadLine();
            double price = 0;
            int nights = days - 1;
            

            if (room == "room for one person")
            {
                price = nights * 18;
            }
            if (room == "apartment")
            {
                price = nights * 25;
                if (nights < 10)
                {
                    price = price - (price * 0.3);
                }
                else if(nights>=10 && nights <= 15)
                {
                    price = price - (price * 0.35);
                }
                else if (nights > 15)
                {
                    price = price - (price * 0.50);
                }
            }
            if(room=="president apartment")
            {
                price = nights * 35;
                if (nights < 10)
                {
                    price = price - (price * 0.10);
                }
                else if (nights >= 10 && nights <= 15)
                {
                    price = price - (price * 0.15);
                }
                else if (nights > 15)
                {
                    price = price - (price * 0.20);
                }
            }
            if (rate == "positive")
            {
                price = price + (price * 0.25);
            }
            else if (rate == "negative")
            {
                price = price - (price * 0.10);
            }
            Console.WriteLine($"{price:f2}");

        }
    }
}
