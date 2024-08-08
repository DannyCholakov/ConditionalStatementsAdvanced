namespace FruitShop;

class Program
{
    static void Main(string[] args)
    {
        string fruit = Console.ReadLine();
        string dayofWeek = Console.ReadLine();
        double number = double.Parse(Console.ReadLine());

        switch (dayofWeek)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday": 
            case "Friday":
                switch (fruit)
                {
                   case "banana": Console.WriteLine((number*2.50).ToString("f2")); break;
                   case "apple":Console.WriteLine((number*1.20).ToString("f2")); break;
                   case "orange":Console.WriteLine((number*0.85).ToString("f2")); break;
                   case "grapefruit":Console.WriteLine((number*1.45).ToString("f2")); break;
                   case "kiwi":Console.WriteLine((number*2.70).ToString("f2")); break;
                   case"pineapple":Console.WriteLine((number*5.50).ToString("f2")); break;
                   case "grapes":Console.WriteLine((number*3.85).ToString("f2")); break;
                   default: Console.WriteLine("error");break;
                }
                break;
            case "Saturday":
            case "Sunday":
                switch (fruit)
                {
                    case "banana": Console.WriteLine((number*2.70).ToString("f2")); break;
                    case "apple":Console.WriteLine((number*1.25).ToString("f2")); break;
                    case "orange":Console.WriteLine((number*0.9).ToString("f2")); break;
                    case "grapefruit":Console.WriteLine((number*1.60).ToString("f2")); break;
                    case "kiwi":Console.WriteLine((number*3.0).ToString("f2")); break;
                    case"pineapple":Console.WriteLine((number*5.60).ToString("f2")); break;
                    case "grapes":Console.WriteLine((number*4.2).ToString("f2")); break;
                    default: Console.WriteLine("error");break;
                }
                break;
            default: Console.WriteLine("error");break;
        }
    }
}