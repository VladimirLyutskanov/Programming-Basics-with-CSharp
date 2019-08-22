using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            int stepsGoal = 10000;
            while (true)
            {
                string input = Console.ReadLine();

                if(input=="Going home")
                {
                   int goingHome=int.Parse (Console.ReadLine());
                   totalSteps += goingHome;
                    if (totalSteps >= stepsGoal)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }

                    else
                    {
                        int stepsLeft = stepsGoal - totalSteps;
                        Console.WriteLine($"{stepsLeft} more steps to reach goal.");
                        break;
                    }

                }
                int steps = int.Parse(input);
                totalSteps += steps;
                if (totalSteps >= stepsGoal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }
            }

        }
    }
}
