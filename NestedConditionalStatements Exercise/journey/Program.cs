using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            //
            double spendMoney = 0;
            string destination = "";
            string acc = "";
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    spendMoney = budget * 0.3;
                    acc = "Camp";
                }
                else if (season == "winter")
                {
                    spendMoney = budget * 0.7;
                    acc = "Hotel";
                }
                destination = "Bulgaria";
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    spendMoney = budget * 0.4;
                    acc = "Camp";
                }
                else if (season == "winter")
                {
                    spendMoney = budget * 0.8;
                    acc = "Hotel";
                }
                destination = "Balkans";
            }
            else if (budget > 1000)
            {
                spendMoney = budget * 0.9;
                acc = "Hotel";
                destination = "Europe";
            }
            Console.WriteLine($"Somewhere in { destination}");
            Console.WriteLine($"{acc} - {spendMoney:f2}");
        }
    }
}
