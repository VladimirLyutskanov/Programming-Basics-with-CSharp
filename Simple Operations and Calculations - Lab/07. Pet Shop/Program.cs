using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = a * b * c;
            double litres = volume * 0.001;
            double realPercent = percent * 0.01;
            double realVolume = litres * (1 - realPercent);

            Console.WriteLine($"{realVolume:F3}");
        }
    }
}
