using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int convMinutes = hours * 60 + minutes;
            int fifteen = convMinutes + 15;
            int finalHour = fifteen / 60;
            int FinalMinutes = fifteen % 60;
            if (finalHour >= 24)
            {
                finalHour -= 24;
            }          

            if (FinalMinutes < 10)
            {
                Console.WriteLine($"{finalHour + ":0" + FinalMinutes}");
            }
            else if (FinalMinutes >= 10)
            {
                Console.WriteLine($"{finalHour + ":" + FinalMinutes}");
            }
            

        }
    }
}
