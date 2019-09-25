using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string appliance = Console.ReadLine();

            double result = 0;

            if (country == "Russia")
            {
                if (appliance == "ribbon")
                {
                    result = 18.500;
                }
                if (appliance == "hoop")
                {
                    result = 19.100;
                }
                if (appliance == "rope")
                {
                    result = 18.600;
                }

            }
            if (country == "Bulgaria")
            {
                if (appliance == "ribbon")
                {
                    result = 19.000;
                }
                if (appliance == "hoop")
                {
                    result = 19.300;
                }
                if (appliance == "rope")
                {
                    result = 18.900;
                }

            }
            if (country == "Italy")
            {
                if (appliance == "ribbon")
                {
                    result = 18.700;
                }
                if (appliance == "hoop")
                {
                    result = 18.800;
                }
                if (appliance == "rope")
                {
                    result = 18.850;
                }

            }
            double percent = (20 - result) / 20 * 100;
            Console.WriteLine($"The team of {country} get {result:f3} on {appliance}.");
            Console.WriteLine($"{percent:f2}%");

        }
    }
}
