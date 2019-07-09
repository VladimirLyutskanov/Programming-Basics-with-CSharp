using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tables = double.Parse(Console.ReadLine());
            double tablesLenght = double.Parse(Console.ReadLine());
            double tablesWidth = double.Parse(Console.ReadLine());
            double tabelearea = tables * (tablesLenght + 2 * 0.3) * (tablesWidth + 2 * 0.3);
            double squarearea = tables * (tablesLenght / 2) * (tablesLenght / 2);
            double priceUsd = tabelearea * 7 + squarearea * 9;
            double priceLeva = priceUsd * 1.85;

            Console.WriteLine($"{priceUsd:F2} USD");
            Console.WriteLine($"{priceLeva:F2} BGN");
        }
    }
}
