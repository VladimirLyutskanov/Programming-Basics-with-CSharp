using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sum = first + second + third;
            int minutes = sum/60;
            int seconds = sum % 60;

            if (seconds <= 9)
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }

        }
    }
}
