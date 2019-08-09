using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            double count = double.Parse (Console.ReadLine());
            double budget =double.Parse (Console.ReadLine());
            double price = 0;

            if(flower== "Roses")
            {
                if (count > 80)
                {
                    price = (count * 5) - (count * 5 * 0.1);
                }
                else if (count <= 80)
                {
                    price = count * 5;
                }
            }
            else if(flower== "Dahlias")
            {
                if (count > 90)
                {
                    price = (count * 3.80) - (count * 3.80 * 0.15);
                }
                else if (count <= 90)
                {
                    price = count * 3.80;
                }
            }
            else if(flower== "Tulips")
            {
                if (count > 80)
                {
                    price = (count * 2.80) - (count * 2.80 * 0.15);
                }
                else if (count <= 80)
                {
                    price = count * 2.80;
                }
            }
            else if(flower== "Narcissus")
            {
                if (count < 120)
                {
                    price = (count * 3) + (count * 3 * 0.15);
                }
                else if(count>=120)
                {
                    price = count * 3;
                }
            }
            else if(flower== "Gladiolus")
            {
                if (count < 80)
                {
                    price = (count * 2.50) + (count * 2.50 * 0.20);
                }
                else if (count >= 80)
                {
                    price = count * 2.50;
                }
            }
            double less = price - budget;

            double more = budget - price;
            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {(budget - price):f2} leva left.");
            }
            else if (budget < price)
            {
                Console.WriteLine($"Not enough money, you need {less:f2} leva more.");
            }



        }
    }
}
