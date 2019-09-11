using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int letter =0;
           
            for (int i = 0; i < word.Length; i++)


            {
                letter = word[i];   //convert chart to ASCII

                Console.WriteLine(letter);

            }
         

        }
    }
}
