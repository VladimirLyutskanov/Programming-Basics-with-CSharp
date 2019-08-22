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

            while (count <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    sum += grade;
                    count++;

                }
            }
            double average = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {average:f2}");

        }
    }
}
