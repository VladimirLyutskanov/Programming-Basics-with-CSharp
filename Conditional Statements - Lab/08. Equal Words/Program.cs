using System;

namespace _08._Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstword = Console.ReadLine();
            string secondword = Console.ReadLine();
            firstword = firstword.ToUpper();
            secondword = secondword.ToUpper();
            if (firstword == secondword)

            {
                Console.WriteLine("yes");
            }
            else

            {
                Console.WriteLine("no");
            }
        }
    }
}
