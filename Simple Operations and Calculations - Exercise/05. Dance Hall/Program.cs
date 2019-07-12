using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobe = double.Parse(Console.ReadLine());
            double areahall = (lenght * 100) * (width * 100);
            double areawardrobe = (wardrobe * 100) * (wardrobe * 100);
            double bench = areahall / 10;
            double space = areahall - areawardrobe - bench;
            double count = space / (7000 + 40);


            Console.WriteLine(Math.Floor(count));

        }
    }
}
