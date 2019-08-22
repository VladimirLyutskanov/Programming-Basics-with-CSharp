using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int hightt = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int freeSpace = lenght * width * hightt;
            string command = Console.ReadLine();
            while (command != "Done")
            {
                int box = int.Parse(command);
                freeSpace -= box;
                if (freeSpace <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if(freeSpace>0)
            { 
            Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
