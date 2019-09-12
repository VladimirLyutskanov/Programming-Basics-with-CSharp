using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double sumAllGrades = 0;
            int countgrade = 0;
            while (presentation!="Finish")
            {
                double sumOfGrades = 0;
                for (int gradesCount=0; gradesCount < jury; gradesCount++)
                {
                    double grades =double.Parse (Console.ReadLine());
                    countgrade++;
                    sumOfGrades += grades;
                    sumAllGrades += grades;

                }
                double average = sumOfGrades / jury;
                Console.WriteLine($"{presentation} - {average:f2}.");

                presentation = Console.ReadLine();
            }
            double avergeAllGrades = sumAllGrades / countgrade;
            Console.WriteLine($"Student's final assessment is {avergeAllGrades:f2}.");



        }
    }
}
