using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace names
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLetterSum = int.MinValue;
            string winnerName = "";
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {

                    break;
                }

                int total = 0;
                for (int i=0; i < input.Length; i++)
                {
                    int letter =input[i];   //convert chart to ASCII
                    total += letter;
                    if (total > maxLetterSum)
                    {
                        maxLetterSum = total;
                        winnerName = input;
                        
                    }
                }

               

             
            }
            Console.WriteLine($"Winner is {winnerName} - {maxLetterSum}!");



        }
    }
}
