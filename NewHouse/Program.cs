using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double pricePerFlower = 0;
            double discount = 0;
            double extraCharge = 0;

            switch (flower)
            {
                case "Roses":
                    pricePerFlower = 5;
                    if (flowersCount > 80)
                    {
                        discount = 0.10;
                    }
                    break;
                case "Dahlias":
                    pricePerFlower = 3.80;
                    if (flowersCount > 90)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Tulips":
                    pricePerFlower = 2.80;
                    if (flowersCount > 80)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Narcissus":
                    pricePerFlower = 3;
                    if (flowersCount < 120)
                    {
                        extraCharge = 0.15;
                    }
                    break;
                case "Gladiolus":
                    pricePerFlower = 2.50;
                    if (flowersCount < 80)
                    {
                        extraCharge = 0.20;
                    }
                    break;
            }

            double totalPrice = flowersCount * pricePerFlower;

            if (discount > 0)
            {
                totalPrice -= totalPrice * discount;
            }

            if (extraCharge > 0)
            {
                totalPrice += totalPrice * extraCharge;
            }

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flower} and {(budget - totalPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(totalPrice - budget):f2} leva more.");
            }
        }
    }
}
