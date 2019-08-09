using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            double result = 0;
            string evenOrodd = "";
            if (action == "+")
            {
                result = N1 + N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {action} {N2} = {result} - {"even"}");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{N1} {action} {N2} = {result} - {"odd"}");
                }
            }
            else if (action == "-")
            {
                result = N1 - N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {action} {N2} = {result} - {"even"}");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{N1} {action} {N2} = {result} - {"odd"}");
                }
            }
            else if (action == "*")
            {
                result = N1 * N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {action} {N2} = {result} - {"even"}");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{N1} {action} {N2} = {result} - {"odd"}");
                }
            }
            else if(action == "/")
            {
                result = N1 / N2;
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else if (N2 != 0)
                {
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} {action} {N2} = {result:f2}");
                    }
                    else if (result % 2 != 0)
                    {
                        Console.WriteLine($"{N1} {action} {N2} = {result:f2}");
                    }

                }

            }
            else if (action == "%")
            {
                result = N1 % N2;
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else if (N2 != 0)
                {
                  
                        Console.WriteLine($"{ N1} % { N2} = {N1 % N2}");

                }
            }






        }
    }
}
