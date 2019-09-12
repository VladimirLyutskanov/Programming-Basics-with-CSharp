using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddEven2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNUmber = int.Parse(Console.ReadLine());
            int secondNUmber = int.Parse(Console.ReadLine());

            for (int i = firstNUmber; i <= secondNUmber; i++)
            {
                string currentNumber = i.ToString();
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j <= 1; j++)
                {
                    int currentDigit = currentNumber[j];
                    leftSum += currentDigit;

                }
                for (int j = 3; j <= 4; j++)
                {
                    int currentDigit = currentNumber[j];
                    rightSum += currentDigit;
                }
                if (leftSum == rightSum)
                {
                    Console.Write(i + " ");
                }
            }
    }
}
