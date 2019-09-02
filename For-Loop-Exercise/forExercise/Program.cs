using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forExercise
{
    class Program
    {
        static void Main(string[] args)
        {
         for(int i = 6;i < 998; i++)
            {
                if (i % 10==7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
