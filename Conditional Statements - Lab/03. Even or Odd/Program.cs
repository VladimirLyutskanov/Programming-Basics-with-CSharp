﻿using System;

namespace _03._Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isNumberEven = number % 2 == 0;

            if (isNumberEven)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
