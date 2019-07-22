using System;

namespace labs_56_Snaplabs_Rabbit_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var limit = 1000000000;
            var counter = 0;
            var rabbitpopulation = 0;
            while (rabbitpopulation<limit)
            {
                rabbitpopulation = (int)Math.Pow(2.0,counter);
                Console.WriteLine($"There are {rabbitpopulation} after {counter} seconds");
                System.Threading.Thread.Sleep(100);
                counter++;
            }
            Console.WriteLine($"There are {rabbitpopulation} after {counter} seconds");
        }
    }
}
