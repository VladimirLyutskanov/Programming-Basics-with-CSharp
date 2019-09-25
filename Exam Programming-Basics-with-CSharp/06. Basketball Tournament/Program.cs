using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int matchCounter = 0;
            int winConter = 0;
            int loseConter = 0;
            int masterCounter = 0;

            while (true)
            {
                matchCounter = 0;
                name = Console.ReadLine();
                if (name == "End of tournaments")
                {
                    break;
                }

                int matchNumbers = int.Parse(Console.ReadLine());

                for (int i = 0; i < matchNumbers; i++)
                {
                    int home = int.Parse(Console.ReadLine());
                    int away = int.Parse(Console.ReadLine());
                    matchCounter++;
                    masterCounter++;


                    if (home > away)
                    {
                        Console.WriteLine($"Game {matchCounter} of tournament {name}: win with {home - away} points.");
                        winConter++;
                    }
                    if (away > home)
                    {
                        Console.WriteLine($"Game {matchCounter} of tournament {name}: lost with {away - home} points.");
                        loseConter++;
                    }


                }
            }
            double winPercent = winConter * 1.0 / masterCounter * 100;
            double losePecent = loseConter * 1.0 / masterCounter * 100;

            Console.WriteLine($"{winPercent:f2}% matches win");
            Console.WriteLine($"{losePecent:f2}% matches lost");

        }
    }
}
