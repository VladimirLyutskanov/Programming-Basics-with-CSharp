using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for(int firstNumber=0; firstNumber <=n; firstNumber++)
            {
                for (int secondNumber = 0; secondNumber <= n; secondNumber++)
                {
                    for (int thirdNumber = 0; thirdNumber <= n; thirdNumber++)
                    {
                        for (int fourtNumber = 0; fourtNumber <= n; fourtNumber++)
                        {
                            for (int fifthNumber = 0; fifthNumber <= n; fifthNumber++)
                            {
                                int sum = firstNumber + secondNumber + thirdNumber + fourtNumber + fifthNumber;
                                if (sum == n)
                                {
                                    counter++;
                                }


                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
