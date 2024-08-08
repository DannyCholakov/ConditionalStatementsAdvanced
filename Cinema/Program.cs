namespace Cinema;

class Program
{
    static void Main(string[] args)
    {
        string ticket = Console.ReadLine();
        int row = int.Parse(Console.ReadLine());
        int column = int.Parse(Console.ReadLine());

        int seats = row * column;

        if (ticket == "Premiere")
        {
            Console.WriteLine((12 * seats).ToString("f2") + " leva");
        }else if (ticket == "Normal")
        {
            Console.WriteLine((7.50*seats).ToString("f2") + " leva"); 
        }else if (ticket == "Discount")
        {
            Console.WriteLine((5*seats).ToString("f2") + " leva");
        }

    }
}