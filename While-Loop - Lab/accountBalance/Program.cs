﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            double balance = 0;
            while (counter < n)
            {
                double amount = double.Parse(Console.ReadLine());
                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += amount;
                Console.WriteLine($"Increase: {amount:f2}");
                counter++;

            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}