using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalLeftRightPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNUmber = int.Parse(Console.ReadLine());
            int secondNUmber = int.Parse(Console.ReadLine());

            for(int i = firstNUmber;i<= secondNUmber; i++)
            {
                string currentNumber = i.ToString();
                int leftSum = 0;
                int rightSum = 0;
                int middle = 0;

                for (int j = 0; j < currentNumber.Length; j++)
                {
                    int currentDigit = int.Parse((currentNumber)[j].ToString());      //int currentDigit = currentNumber[j];
                                                                                // leftSum += currentDigit;
 
                    if (j <= 1)
                    {
                        leftSum += currentDigit;
                    }
                    else if (j > 2)
                    {
                        rightSum += currentDigit;

                    }
                    else
                    {
                        middle += currentDigit;

                    }
                   
                }

                if (leftSum > rightSum)
                {
                    rightSum += middle;
                }
                else if (rightSum > leftSum)
                {
                    leftSum += middle;
                }
                if (leftSum == rightSum)
                {
                    Console.Write(i + " ");
                }
                
                

            }

        }
    }
}
