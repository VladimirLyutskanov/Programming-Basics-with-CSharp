using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelroom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse (Console.ReadLine());
            double studio = 0;
            double apartment = 0;
            double priceStudio = 0;
            double priceApartament =0;
      

            if (month == "May" || month == "October")
            {
                studio = 50;
                apartment = 65;
                if (days <= 7)
                {
                    priceStudio = days * studio;
                    priceApartament = days * apartment;
                }


                else if (days > 7 && days <= 14)
                {
                    priceStudio = days * studio - (days * studio * 0.05);
                    priceApartament = days * apartment;
                }
                else if (days > 14)
                {
                    priceStudio = days * studio - (days * studio * 0.3);
                    priceApartament = days * apartment - (days * apartment * 0.1);
                }

            }
            else if(month == "June" || month == "September")
            {
                studio = 75.20;
                apartment = 68.70;

                if (days <= 7 || days<=14)
                {
                    priceStudio = days * studio;
                    priceApartament = days * apartment;
                }
                else if (days > 14)
                {

                    priceStudio = days * studio - (days * studio * 0.2);
                    priceApartament = days * apartment - (days * apartment * 0.1);

                }


            }
            else if (month == "July" || month == "August")
            {

                studio = 76;
                apartment = 77;
                if (days <= 14)
                {
                    priceStudio = days * studio;
                    priceApartament = days * apartment;
                }
                   
                else if (days > 14)
                {
                    priceApartament = days*apartment - (days*apartment * 0.1);
                    priceStudio = days * studio;

                }
            }
            Console.WriteLine($"Apartment: {priceApartament:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
            
        
              

        }
    }
}
