namespace NumberInRange;

class Program
{
    static void Main(string[] args)
    {
        double number = double.Parse(Console.ReadLine());

        if (number >= -100 && number <= 100)
        {
            if (number == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}