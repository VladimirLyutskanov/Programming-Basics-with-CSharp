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
            char num = '9';
            int number = int.Parse((num)+"");
            Console.WriteLine(number);
            int sum = number + 33;
            char sumToPrint =(char)(sum);
            Console.WriteLine(sumToPrint);
            string name = "Stanimir";
            char lastLetter = (char)name[name.Length - 1];
            Console.WriteLine(lastLetter);
        }
    }
}
