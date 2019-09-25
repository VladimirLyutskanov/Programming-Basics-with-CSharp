using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace footballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstResult = Console.ReadLine();
            string secondResult = Console.ReadLine();
            string thirdResult = Console.ReadLine();

            int firstResultLenght = firstResult.Length;
            int secondResultLenght = secondResult.Length;
            int thirdresultlenght = thirdResult.Length;

            int counterWins = 0;
            int counterLosts = 0;
            int counterDraws = 0;

            if (firstResult[0] > firstResult[2])
            {
                counterWins++;
            }
            else if (firstResult[0] < firstResult[2])
            {
                counterLosts++;
            }
            else if (firstResult[0] == firstResult[2])
            {
                counterDraws++;
            }

            if (secondResult[0] > secondResult[2])
            {
                counterWins++;
            }
            else if (secondResult[0] < secondResult[2])
            {
                counterLosts++;
            }
            else if (secondResult[0] == secondResult[2])
            {
                counterDraws++;
            }

            if (thirdResult[0] > thirdResult[2])
            {
                counterWins++;
            }
            else if (thirdResult[0] < thirdResult[2])
            {
                counterLosts++;
            }
            else if (thirdResult[0] == thirdResult[2])
            {
                counterDraws++;
            }

            Console.WriteLine($"Team won {counterWins} games.");
            Console.WriteLine($"Team lost {counterLosts} games.");
            Console.WriteLine($"Drawn games: {counterDraws}");


        }
    }
}
