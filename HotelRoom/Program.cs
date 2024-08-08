using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;
                    break;
            }

            double studioStay = days * studioPrice;
            double apartmentStay = days * apartmentPrice;

          
            if ((month == "May" || month == "October") && days > 7 && days <= 14)
            {
                studioStay *= 0.95;
            }
            else if ((month == "May" || month == "October") && days > 14)
            {
                studioStay *= 0.70;
                apartmentStay *= 0.90;
            }
            else if ((month == "June" || month == "September") && days > 14)
            {
                studioStay *= 0.80;
                apartmentStay *= 0.90;
            }
            else if ((month == "July" || month == "August") && days > 14)
            {
                apartmentStay *= 0.90;
            }

            Console.WriteLine($"Apartment: {apartmentStay:f2} lv.");
            Console.WriteLine($"Studio: {studioStay:f2} lv.");
        }
    }
}