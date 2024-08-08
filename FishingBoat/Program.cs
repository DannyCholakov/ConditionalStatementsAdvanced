namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherMan = int.Parse(Console.ReadLine());

            double boatPrice = 0;

            switch (season)
            {
                case "Spring":
                    boatPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    boatPrice = 4200;
                    break;
                case "Winter":
                    boatPrice = 2600;
                    break;
            }
            if (fisherMan <= 6)
            {
                boatPrice *= 0.90;
            }
            else if (fisherMan <= 11)
            {
                boatPrice *= 0.85;
            }
            else
            {
                boatPrice *= 0.75;
            }
            if (season != "Autumn" && fisherMan % 2 == 0)
            {
                boatPrice *= 0.95;
            }

            if (boatPrice <= groupBudget)
            {
                Console.WriteLine($"Yes! You have {(groupBudget - boatPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(boatPrice - groupBudget):f2} leva.");
            }
        }
    }
}