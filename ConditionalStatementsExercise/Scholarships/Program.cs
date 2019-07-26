using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarships
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double success = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            double social = salary * 0.35;
            double excellent = success * 25;

            if (income > salary && success < 5.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            if (income > salary && success >=5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellent} BGN");

            }
            if (income < salary && success >= 5.50)
            {
                Console.WriteLine($"You get a Social scholarship {social} BGN");
            }

            
        }
    }
}
