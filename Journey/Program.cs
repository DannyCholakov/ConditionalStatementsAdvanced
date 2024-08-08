namespace Journey;

class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        string destination = "";
        string placeToStay = "";
        double moneySpend = 0.00;

        if (budget<=100)
        {
            destination = "Bulgaria";
            
        }else if (budget<=1000)
        {
            destination = "Balkans";
        }
        else if(budget>1000)
        {
            destination = "Europe";
        }

        switch (destination)
        {
            case "Bulgaria":
                if (season == "summer")
                {
                    placeToStay = "Camp";
                    moneySpend = budget * 0.30;

                }else if (season =="winter")
                {
                    placeToStay = "Hotel";
                    moneySpend = budget * 0.70;
                }
                break;
            
            case "Balkans":
                if (season == "summer")
                {
                    placeToStay = "Camp";
                    moneySpend = budget * 0.40;

                }else if (season =="winter")
                {
                    placeToStay = "Hotel";
                    moneySpend = budget * 0.80;
                }
                break;
            
            case "Europe":
                placeToStay = "Hotel";
                moneySpend = budget * 0.90;
                break;
        }

        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{placeToStay} - {moneySpend.ToString("f2")}");
    }
}