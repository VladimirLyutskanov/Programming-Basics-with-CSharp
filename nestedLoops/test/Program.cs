using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int total = 0;
            int one = 0;
            int three = 0;
            for (int i = 0; i < word.Length; i++) 
            

            {
                one = word[1];   //convert chart to ASCII
                three = word[3];
                total=one+three;
               
            }
            Console.WriteLine(total);
        }
    }
}
