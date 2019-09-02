using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int Count6 = 0;
            int Count5 = 0;
            int Count4 = 0;
            int Count3 = 0;
            double sum6 = 0;
            double sum5 = 0;
            double sum4 = 0;
            double sum3 = 0;

            for (int i = 1; i <= number; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 5)
                {
                    Count6++;
                    sum6 += grade;
                }
                if (grade >= 4 && grade < 5)
                {
                    Count5++;
                    sum5 += grade;
                }
                if (grade >= 3 && grade < 4)
                {
                    Count4++;
                    sum4 += grade;
                }

                if (grade < 3)
                {
                    Count3++;
                    sum3 += grade;
                }


            }
            double p6 = Count6*1.0 / number * 100;
            double p5 = Count5*1.0/ number * 100;
            double p4 = Count4 *1.0/ number * 100;
            double p3 = Count3*1.0/ number * 100;
            double total = sum3 + sum4 + sum5 + sum6;
            double average = total / number;

            Console.WriteLine($"Top students: {p6:f2}%");            Console.WriteLine($"Between 4.00 and 4.99: {p5:f2}% ");            Console.WriteLine($"Between 3.00 and 3.99: {p4:f2}%");            Console.WriteLine($"Fail: {p3:f2}% ");            Console.WriteLine($"Average: {average:f2}");

        }
    }
}
