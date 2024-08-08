namespace SummerOutfit;

class Program
{
    static void Main(string[] args)
    {
        double degrees = double.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine();

        switch (timeOfDay)
        {
            case "Morning":
                if (degrees >=10 && degrees<=18)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Sweatshirt and Sneakers.");
                }else if (degrees>18 && degrees<=24)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }else if (degrees>24)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                } break;
            case "Afternoon":
                if (degrees >=10 && degrees<=18)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }else if (degrees>18 && degrees<=24)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                }else if (degrees>24)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Swim Suit and Barefoot.");
                } break;
                case "Evening":
                Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                break;
        }
    }
}