using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combinationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int firstNumber = 0; firstNumber <= n; firstNumber++)
            {
                for (int secondNumber = 0; secondNumber <= n; secondNumber++)
                {
                    for (int thirdNumber = 0; thirdNumber <= n; thirdNumber++)
                    {
                        Console.WriteLine($"{firstNumber+"A"}  {secondNumber+"B"}  {thirdNumber+"C"}");
                    }
                }
            }

        }
    }
}
