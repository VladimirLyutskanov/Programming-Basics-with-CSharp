using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int minimun = int.MaxValue;
            

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
               
                int number = int.Parse(command);
                if (number < minimun)
                {
                    minimun = number;

                }
                if (number > max)
                {
                    max = number;
                }
            }
              Console.WriteLine($"Max number: {max}");
              Console.WriteLine($"Min number: {minimun}");
        }
    }
}
