using System;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

           
            int examTimeInMinutes = examHour * 60 + examMinute;
            int arriveTimeInMinutes = arriveHour * 60 + arriveMinute;

           
            int timeDifference = arriveTimeInMinutes - examTimeInMinutes;

           
            if (timeDifference < -30)
            {
                Console.WriteLine("Early");

               
                if (timeDifference <= -60)
                {
                    int hoursEarly = Math.Abs(timeDifference / 60);
                    int minutesEarly = Math.Abs(timeDifference % 60);
                    Console.WriteLine($"{hoursEarly}:{minutesEarly:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(timeDifference)} minutes before the start");
                }
            }
            else if (timeDifference <= 0)
            {
                Console.WriteLine("On time");

                if (timeDifference < 0)
                {
                    Console.WriteLine($"{Math.Abs(timeDifference)} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Late");

               
                if (timeDifference >= 60)
                {
                    int hoursLate = timeDifference / 60;
                    int minutesLate = timeDifference % 60;
                    Console.WriteLine($"{hoursLate}:{minutesLate:D2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{timeDifference} minutes after the start");
                }
            }
        }
    }
}
