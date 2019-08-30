using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceOfWashing = double.Parse(Console.ReadLine());
            double priceOfToy = double.Parse(Console.ReadLine());

            double sumOfToys = 0;
            double sumIfMoney = 0;
            double totalMoney = 0;
            double balance = 0;




            for (int i = 1; i <= age; i++)
            {



                if (i % 2 == 0)
                {
                    sumIfMoney += i * 10 / 2 - 1;
                }
                if (i % 2 != 0)
                {
                    sumOfToys += priceOfToy;
                }

                totalMoney = sumIfMoney + sumOfToys;
                balance = Math.Abs(totalMoney - priceOfWashing);
            }
            if (totalMoney >= priceOfWashing)
            {
                Console.WriteLine($"Yes! {balance:f2}");
            }
            else if (totalMoney < priceOfWashing)
            {
                Console.WriteLine($"No! {balance:f2} ");
            }

        }
    }
}
