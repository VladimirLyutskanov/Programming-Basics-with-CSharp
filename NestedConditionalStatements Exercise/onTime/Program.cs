using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examminutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveminutes = int.Parse(Console.ReadLine());
            int totalExam = examHour * 60 + examminutes;
            int totalArrive = arriveHour * 60 + arriveminutes;
            int displayHour = 0;
            int diplayMinutes = 0;


            if (totalArrive > totalExam)
            {
                displayHour = (totalArrive - totalExam) / 60;
                diplayMinutes = (totalArrive - totalExam) % 60;

                if (arriveHour == examHour)
                {
                    if (diplayMinutes < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"0:{diplayMinutes} minutes after the start");
                    }
                    else if (diplayMinutes >= 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{diplayMinutes} minutes after the start");
                    }


                }
                else if ((totalArrive - totalExam) > 60)
                {
                    if (diplayMinutes < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{displayHour}:0{diplayMinutes} hours after the start");
                    }
                    else if (diplayMinutes >= 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{displayHour}:{diplayMinutes} hours after the start");
                    }
                }
                else if ((totalArrive - totalExam) < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{diplayMinutes} minutes after the start");
                }

                //Console.WriteLine("Late");
                //Console.WriteLine($"{displayHour}:{diplayMinutes}");


            }
            else if ((totalExam - totalArrive) < 30 && (totalExam - totalArrive) != 0)
            {

                diplayMinutes = (totalExam - totalArrive);
                Console.WriteLine("On time");
                Console.WriteLine($"{diplayMinutes} minutes before the start");
            }
            else if ( totalExam-totalArrive == 0)
            {
                Console.WriteLine("On time");
            }

            else if ((totalExam - totalArrive) >= 30)
            {
                if ((totalExam - totalArrive) >= 60)
                {
                    displayHour = (totalExam - totalArrive) / 60;
                    diplayMinutes = (totalExam - totalArrive) % 60;
                    if (diplayMinutes <= 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{displayHour}:0{diplayMinutes} hours before the start");
                    }
                    else if (diplayMinutes > 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{displayHour} : {diplayMinutes} hours before the start");
                    }
                }
                else if ((totalExam - totalArrive) < 60)
                {
                    diplayMinutes = (totalExam - totalArrive);

                    Console.WriteLine("Early");
                    Console.WriteLine($"{diplayMinutes} minutes before the start");

                }
            }
            
        }
    }
}
