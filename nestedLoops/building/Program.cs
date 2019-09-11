using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int floorNumber = floors; floorNumber > 0; floorNumber--)
            {
                if (floorNumber % 2 == 0)
                {
                    for (int roomsNumber = 0; roomsNumber < rooms; roomsNumber++)


                    {
                        if (floorNumber == floors)
                        {
                            Console.Write($"L{floorNumber}{roomsNumber} ");
                        }
                        else
                        {
                            Console.Write($"O{floorNumber}{roomsNumber} ");
                        }
                       

                    }

                }
                else 

                    for (int roomsNumber = 0; roomsNumber < rooms; roomsNumber++)
                    {
                        if (floorNumber == floors)
                        {
                            Console.Write($"L{floorNumber}{roomsNumber} ");
                        }
                        else
                        {
                            Console.Write($"A{floorNumber}{roomsNumber} ");
                        }
                               
                        
                    }
                Console.WriteLine();

            }
        }
    }
}
