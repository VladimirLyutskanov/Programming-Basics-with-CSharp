using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax = double.Parse(Console.ReadLine());

            double trainers = tax * 0.6;
            double equipment = trainers * 0.8;
            double ball = equipment / 4;
            double acc = ball / 5;

            double total = tax + trainers + equipment + ball + acc;
            Console.WriteLine($"{total:f2}");
        }
    }
}