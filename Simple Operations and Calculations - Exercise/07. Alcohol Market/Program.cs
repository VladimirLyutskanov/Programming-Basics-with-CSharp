using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double quantityBeer = double.Parse(Console.ReadLine());
            double quantityWine = double.Parse(Console.ReadLine());
            double quantityBrandy = double.Parse(Console.ReadLine());
            double quantityWiskey = double.Parse(Console.ReadLine());
            //ok
            double brandyprice = wiskeyPrice * 0.5;
            double wineprice = brandyprice - (brandyprice * 0.4);
            double beerprice = brandyprice - (brandyprice * 0.8);
            //ok
            double wiskeysum = wiskeyPrice * quantityWiskey;
            double beersum = beerprice * quantityBeer;
            double winesum = wineprice * quantityWine;
            double brandysum = brandyprice * quantityBrandy;
            double sum = wiskeysum + beersum + winesum + brandysum;

            Console.WriteLine($"{sum:F2}");
        }
    }
}
