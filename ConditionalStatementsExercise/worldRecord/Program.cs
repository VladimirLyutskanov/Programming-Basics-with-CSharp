using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double meterInSeconds = double.Parse(Console.ReadLine());
            double resistance = Math.Floor(distance / 15) * 12.5;
            double time = meterInSeconds * distance + resistance;

            if (time < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {time:f2} seconds.");
            }
            else
            {
                double needed = time - record;
                Console.WriteLine($"No, he failed! He was {needed:f2} seconds slower.");

            }

        }
    }
}
