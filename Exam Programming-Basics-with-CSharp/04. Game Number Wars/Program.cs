using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();

            string input = string.Empty;
            int score1 = 0;
            int score2 = 0;

            while (input != "End of game")
            {
                input = Console.ReadLine();
                if (input == "End of game")
                {
                    Console.WriteLine($"{name1} has {score1} points");
                    Console.WriteLine($"{name2} has {score2} points");
                    break;
                }
                int first = int.Parse(input);
                int second = int.Parse(Console.ReadLine());

                if (first > second)
                {
                    score1 += first - second;
                }
                else if (second > first)
                {
                    score2 += second - first;
                }

                if (first == second)
                {
                    int last1 = int.Parse(Console.ReadLine());
                    int last2 = int.Parse(Console.ReadLine());
                    if (last1 > last2)
                    {
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{name1} is winner with {score1} points");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{name2} is winner with {score2} points");
                        break;
                    }
                }

            }
        }
    }
}
