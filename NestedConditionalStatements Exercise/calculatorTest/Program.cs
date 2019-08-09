using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = (630 - 540)/60;
            double numbermin = (630 - 540) % 60;
            Console.WriteLine($"{number}:{numbermin}");
        }
    }
}
