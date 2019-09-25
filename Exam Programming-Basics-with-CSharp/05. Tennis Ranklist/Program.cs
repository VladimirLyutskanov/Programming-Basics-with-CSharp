using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startPoint = int.Parse(Console.ReadLine());

            int W = 2000;
            int F = 1200;
            int SF = 720;
            int total = startPoint;
            int winCounter = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string name = Console.ReadLine();
                if (name == "W")
                {
                    total += W;
                    winCounter++;
                }
                if (name == "F")
                {
                    total += F;
                }
                if (name == "SF")
                {
                    total += SF;
                }
            }
            double average = Math.Floor((1.0 * total - startPoint) / tournaments);
            double percent = (1.0 * winCounter / tournaments) * 100;
            Console.WriteLine($"Final points: {total}");
            Console.WriteLine($"Average points: {average}");
            Console.WriteLine($"{percent:f2}% ");

        }
    }
}
