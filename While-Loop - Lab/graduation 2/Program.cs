using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double count = 1;
            double sum = 0;
            int badgrades = 0;

            while (count <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    sum += grade;
                    count++;
                }
                else
                {
                    badgrades++;
                    if (badgrades >= 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {count} grade");
                        break;
                    }
                }
            }
            if (badgrades < 2)
            {
                double average = sum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}