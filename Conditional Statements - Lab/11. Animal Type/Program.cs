using System;

namespace _11._Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string animaltype = Console.ReadLine();
            switch (animaltype)
            {
                case "dog":
                    {
                        Console.WriteLine("mammal");
                        break;
                    }

                case "crocodile":
                case "tortoise":
                case "snake":
                    {
                        Console.WriteLine("reptile");
                        break;
                    }
                case "cat":
                    {
                        Console.WriteLine("unknown");
                        break;
                    }
            }
        }
    }
}
