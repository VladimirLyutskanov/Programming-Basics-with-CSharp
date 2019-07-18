using System;

namespace _09._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFifure = Console.ReadLine();
            if (typeOfFifure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * a:F3}");
            }
            else if (typeOfFifure == "rectangle")
            {
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine($"{b * c:F3}");
            }
            else if (typeOfFifure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double pi = Math.PI;
                Console.WriteLine($"{r * r * pi:F3}");
            }
            else
            {
                double d = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine($"{d * h / 2:F3}");

            }
        }
    }
}
