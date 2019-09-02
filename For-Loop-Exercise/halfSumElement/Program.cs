using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int sum = 0;
            

            ;
            for (int i = 0; i < count; i++)
            {
               int number = int.Parse(Console.ReadLine());
                sum += number;
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            
            int diff = sum - maxNumber;
            int equal = Math.Abs (maxNumber - diff);
            if (diff == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {diff}");
            }

            else if (diff != maxNumber)

                
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {equal}");
            }
        }
    }
}
