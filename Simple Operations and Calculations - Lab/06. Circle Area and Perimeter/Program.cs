﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;

            Console.WriteLine("{0:F2}", area);
            Console.WriteLine("{0:F2}", perimeter);
        }
    }
}
