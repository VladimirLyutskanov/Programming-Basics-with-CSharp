using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double timeBrother1 = double.Parse(Console.ReadLine());
            double timeBrother2 = double.Parse(Console.ReadLine());
            double timeBrother3 = double.Parse(Console.ReadLine());
            double fishingTime = double.Parse(Console.ReadLine());
            double work = 1 / (1 / timeBrother1 + 1 / timeBrother2 + 1 / timeBrother3);
            double relax = work * 0.15;
            double time = work+ relax;
            Console.WriteLine($"Cleaning time: {time:f2}");
            double left = Math.Floor(fishingTime - time);
            if (time <= fishingTime)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {left} hours.");
            }
            else
            {
                double needed = Math.Ceiling(time-fishingTime);
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {needed} hours.");
            }
        }
    }
}
