using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter b");
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine(a * b);
        }
    }
}
