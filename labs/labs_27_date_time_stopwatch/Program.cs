using System;
using System.Diagnostics;

namespace labs_27_date_time_stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Times

            var time01 = DateTime.Now;
            Console.WriteLine(time01);
            Console.WriteLine(time01.ToLongDateString());

            //add units of time

            Console.WriteLine(time01.AddTicks(2));
            Console.WriteLine(time01.AddMilliseconds(500));
            Console.WriteLine(time01.AddSeconds(200));
            Console.WriteLine(time01.AddMinutes(30));
            Console.WriteLine(time01.AddHours(4));
            Console.WriteLine(time01.AddDays(2));
            Console.WriteLine(time01.AddMonths(4));

            //measure time
            //lets count to 1 million and measure the time
            Console.WriteLine("\n\nStarting The Stopwatch\n\n");
            var s = new Stopwatch();
            s.Start();
            int count = 0;
            //run code
            for (long i = 0; i<1_000_000_000_000; i++)
            {
                count++;
            }
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);
            Console.WriteLine(s.ElapsedTicks);
        }
    }
}
