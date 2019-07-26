using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double stepsPerDay = Math.Ceiling(steps*1.0 / days)/steps*100.00;
            double percentPerDancer = stepsPerDay / dancers;
            
            if (stepsPerDay <=13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {percentPerDancer:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, they will not succeed in that goal! Required {percentPerDancer:f2}% steps to be learned per day.");

            }
        }
    }
}
