using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedLoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            for(int thousands = a; thousands <= b; thousands++)
            {
                for (int hundreds = a; hundreds <= b; hundreds++)
                {
                    for (int tens = c; tens <= d; tens++)
                    {
                        for (int units = c; units <= d; units++)
                        {
                            bool equalSum = thousands + units == hundreds + tens;
                            bool thousandsDiff = thousands != hundreds;
                            bool tensDiff = tens != units;
                            if(equalSum && thousandsDiff && tensDiff)
                            {
                                Console.WriteLine("" +thousands +hundreds);
                                Console.WriteLine("" + tens + units);
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }

        }
    }
}
