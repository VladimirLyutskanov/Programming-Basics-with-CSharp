using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double coffeeshop = double.Parse(Console.ReadLine());
            double cakecount = double.Parse(Console.ReadLine());
            double waffelcounf = double.Parse(Console.ReadLine());
            double pancekecount = double.Parse(Console.ReadLine());
            //ok
            double count = days * coffeeshop;
            double cake = cakecount * count * 45;
            double waffel = waffelcounf * count * 5.80;
            double pancake = pancekecount * count * 3.20;
            double charityvalue = (cake + waffel + pancake) - (cake + waffel + pancake) / 8;

            Console.WriteLine($"{charityvalue:F2}");
        }
    }
}
