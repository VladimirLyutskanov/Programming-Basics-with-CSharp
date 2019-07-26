using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string metricInput = Console.ReadLine();
            string metricOutput = Console.ReadLine();
            if (metricInput == "mm")
            {
                value /= 1000;
            }
            else if (metricInput == "sm")
            {
                value /= 100;
            }
            if (metricOutput == "mm")
            {
                value *= 1000;
            }
            else if (metricOutput == "sm")
            {
                value *= 100;
            }
            Console.WriteLine($"{value:F3}");



        }
    }
}
