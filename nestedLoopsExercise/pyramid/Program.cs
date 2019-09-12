using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string number = "" + n;
            int lenght = number.Length;
            for(int i = lenght-1 ; i >= 0; i--)
            {
                int lastnumber=int.Parse(number[i]+"");
                if (lastnumber == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }

                char lastsymbol = (char)(lastnumber + 33);
                for (int last = 0; last < lastnumber; last++)
                {
                            
                    Console.Write(lastsymbol);

                  

                }
                Console.WriteLine();
                
            }

        }
    }
}
