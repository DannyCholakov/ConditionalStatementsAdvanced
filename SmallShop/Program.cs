    namespace SmallShop;

class Program
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();
        string city = Console.ReadLine();
        double number = double.Parse(Console.ReadLine());

        switch (product)
        {
            case "coffee":
                switch (city)
                {
                    case "Sofia": Console.WriteLine(number * 0.5);
                        break;
                    case "Plovdiv": Console.WriteLine(number * 0.4);
                        break;
                    case "Varna": Console.WriteLine(number * 0.45);
                        break;
                }
                break;
            case "water":
                switch (city)
                {
                    case "Sofia": Console.WriteLine(number * 0.8);
                        break;
                    case "Plovdiv": Console.WriteLine(number * 0.7);
                        break;
                    case "Varna": Console.WriteLine(number * 0.7);
                        break;
                }
                break;
            case "beer":
                switch (city)
                {
                    case "Sofia": Console.WriteLine(number * 1.2);
                        break;
                    case "Plovdiv": Console.WriteLine(number * 1.15);
                        break;
                    case "Varna": Console.WriteLine(number * 1.10);
                        break;
                }
                break;
            case "sweets":
                switch (city)
                {
                    case "Sofia": Console.WriteLine(number * 1.45);
                        break;
                    case "Plovdiv": Console.WriteLine(number * 1.3);
                        break;
                    case "Varna": Console.WriteLine(number * 1.35);
                        break;
                }
                break;
            case "peanuts":
                switch (city)
                {
                    case "Sofia": Console.WriteLine(number * 1.6);
                        break;
                    case "Plovdiv": Console.WriteLine(number * 1.5);
                        break;
                    case "Varna": Console.WriteLine(number * 1.55);
                        break;
                }
                break;
        }
    }
}