using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dividewithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;

            for (int i = 1; i <= number; i++)
            {
                int value = int.Parse(Console.ReadLine());
                if(value % 2 == 0)
                {
                    counter2++;
                }
                if(value % 3 == 0)
                {
                    counter3++;
                }
                if (value % 4 == 0)
                {
                    counter4++;
                }
            }
            double p2 = counter2 * 1.0 / number * 100;
            double p3 = counter3 * 1.0 / number * 100;
            double p4 = counter4 * 1.0 / number * 100;
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
        }
    }
}
