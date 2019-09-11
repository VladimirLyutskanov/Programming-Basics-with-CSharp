using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forInFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;

            int b = 3;

            for (int i = 0; i < a; i++)

            {

                Console.WriteLine("i = " + i);

                for (int j = 0; j < b; j++)

                {

                    Console.WriteLine("j = " + j);

                }

                Console.WriteLine();

            }
        }
    }
}
