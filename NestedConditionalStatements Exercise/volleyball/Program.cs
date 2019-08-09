using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holydays = double.Parse(Console.ReadLine());
            double homeweekdays = double.Parse(Console.ReadLine());

            double sofiagames = (48 - homeweekdays)/4*3;
            double sofiaholydays = holydays / 3 * 2;
            double total = 0;
            if (year == "normal")
            {
                total = sofiagames + sofiaholydays + homeweekdays;
            }
            else if(year == "leap")
            {
                total = (sofiagames + sofiaholydays + homeweekdays)+(sofiagames + sofiaholydays + homeweekdays)*0.15;
            }
            double round = Math.Floor(total);
            Console.WriteLine(round);



        }
    }
}
