using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_към_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double lev = usd * 1.79549;
            Console.WriteLine(Math.Round(lev, 2));
        }
    }
}
