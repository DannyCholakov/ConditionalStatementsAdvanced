using System;

namespace OperationsBetweenOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            if (operation == '/' || operation == '%' && y == 0)
            {
                Console.WriteLine($"Cannot divide {x} by zero");
                return;
            }

            double result = 0;
            string resultType = "";

            switch (operation)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    result = (double)x / y;
                    break;
                case '%':
                    result = x % y;
                    break;
            }

            if (operation == '+' || operation == '-' || operation == '*')
            {
                resultType = (result % 2 == 0) ? "even" : "odd";
                Console.WriteLine($"{x} {operation} {y} = {result} - {resultType}");
            }
            else if (operation == '/')
            {
                Console.WriteLine($"{x} / {y} = {result:f2}");
            }
            else if (operation == '%')
            {
                Console.WriteLine($"{x} % {y} = {result}");
            }
        }
    }
}