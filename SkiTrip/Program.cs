namespace SkiTrip;

class Program
{
    static void Main(string[] args)
    {
        int daysOfStay = int.Parse(Console.ReadLine());
        string typeOfRoom = Console.ReadLine();
        string score = Console.ReadLine();

        int nights = daysOfStay - 1;
        double roomPrice = 0;
        double promotion = 0;
        double bonusPromo = 0;
        switch (typeOfRoom)
        {
            case "apartment":
                roomPrice = 25;
                if (nights<10)
                {
                    promotion = 0.70;
                }else if (nights<=15)
                {
                    promotion = 0.65;
                }
                else
                {
                    promotion = 0.50;
                }
                break;
            case "president apartment":
                roomPrice = 35;
                if (nights<10)
                {
                    promotion = 0.90;
                }else if (nights<=15)
                {
                    promotion = 0.85;
                }
                else
                {
                    promotion = 0.80;
                }
                break;
            case "room for one person":
                roomPrice = 18;
                promotion = 1; break;
        }

        switch (score)
        {
            case "positive":
                bonusPromo = 1.25;
                break;
            case "negative":
                bonusPromo = 0.90;
                break;
        }

        Console.WriteLine($"{(((roomPrice*nights)*promotion)*bonusPromo).ToString("f2")}");
    }
}


// namespace SkiTrip
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int daysOfStay = int.Parse(Console.ReadLine());
//             string typeOfRoom = Console.ReadLine();
//             string feedback = Console.ReadLine();
//
//             int nights = daysOfStay - 1;
//             double roomPricePerNight;
//
//             // Определяне на базова цена на нощувка
//             switch (typeOfRoom)
//             {
//                 case "apartment":
//                     roomPricePerNight = 25;
//                     break;
//                 case "president apartment":
//                     roomPricePerNight = 35;
//                     break;
//                 case "room for one person":
//                     roomPricePerNight = 18;
//                     break;
//                 default:
//                     roomPricePerNight = 0;
//                     break;
//             }
//
//             // Приложение на промоция в зависимост от типа стая и броя на нощувките
//             double discount = 1.0;
//             if (typeOfRoom == "apartment")
//             {
//                 if (nights < 10) discount = 0.70;
//                 else if (nights <= 15) discount = 0.65;
//                 else discount = 0.50;
//             }
//             else if (typeOfRoom == "president apartment")
//             {
//                 if (nights < 10) discount = 0.90;
//                 else if (nights <= 15) discount = 0.85;
//                 else discount = 0.80;
//             }
//
//             // Изчисляване на крайната цена с отстъпката
//             double totalPrice = nights * roomPricePerNight * discount;
//
//             // Приложение на бонус или малус според отзива
//             double feedbackMultiplier = feedback == "positive" ? 1.25 : 0.90;
//             totalPrice *= feedbackMultiplier;
//
//             // Показване на резултата
//             Console.WriteLine($"{totalPrice:F2}");
//         }
//     }
// }
