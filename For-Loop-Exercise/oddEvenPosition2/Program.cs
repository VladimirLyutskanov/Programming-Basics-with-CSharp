using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddEvenPosition2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;
            double oddSum = 0;

            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;
            double evenSum = 0;
            
            for(int i = 1; i <= number; i++)
            {
                double value = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    if (value > evenMax)
                    {
                        evenMax = value;
                    }
                    if (value < evenMin)
                    {
                        evenMin = value;
                    }
                    evenSum += value;
                }
                else if (i % 2 != 0)
                {
                    if (value > oddMax)
                    {
                        oddMax = value;
                    }
                    if (value < oddMin)
                    {
                        oddMin = value;
                    }
                    oddSum += value;
                }
            }
            if (number >= 2)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            
                   

                

        }
    }
}
