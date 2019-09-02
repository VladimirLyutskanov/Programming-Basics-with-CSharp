using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int count200 = 0;
            int count399 = 0;
            int count599 = 0;
            int count799 = 0;
            int count800 = 0;
          

            for (int i = 1; i <= numbers; i++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value<200)
                {
                    count200++;
                    

                }
               else if (value>=200&& value<=399)
                {
                    count399++;
                    
                }
                else if (value >= 400 && value <= 599)
                {
                    count599++;
                    
                }
                else if (value >= 600 && value <= 799)
                {
                    count799++;
                    
                }
                else if (value >=800)
                {
                    count800++;
                    
                }

            }
            double p1 = count200 *1.0 / numbers * 100;
            double p2 = count399*1.0/ numbers * 100;
            double p3 = count599 *1.0/ numbers * 100;
            double p4 = count799*1.0 / numbers * 100;
            double p5 = count800*1.0/ numbers * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
