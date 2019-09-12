using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalSumEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for(int i = firstNumber; i <= secondNumber; i++)
            {
                string currentNumber = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int j = 0; j < currentNumber.Length; j++)
                {
                    int currentDigit = int.Parse(currentNumber[j].ToString()); // int.Parse((currentNumber)[j]+"") 
                    if (j % 2 == 0)
                    {
                        evenSum+=currentDigit;
                    }
                    else
                    {
                        oddSum+=currentDigit;
                    }

                }
                if (evenSum == oddSum)
                {
                    Console.Write(i+ " ");
                }

            }
        }
    }
}
