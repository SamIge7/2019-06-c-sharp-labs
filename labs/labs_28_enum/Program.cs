using System;

namespace labs_28_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fruit.banana); 
            Console.WriteLine(Fruit.apple); 
            Console.WriteLine(Fruit.pear);

            Console.WriteLine(   (int)Fruit.apple      );
            Console.WriteLine($"Number of fruits is {(int)Fruit.count}");

            // use with days of week and months of year
            // Sunday = 0, Saturday is 6
            // January is 1, December is 12
            var d = DateTime.Now;
            Console.WriteLine(d);
            Console.WriteLine(d.Month);
            Console.WriteLine(d.Day); //Day of Month

            Console.WriteLine((int)d.DayOfWeek);
            Console.WriteLine(d.DayOfWeek);
        }
    }
    
    enum Fruit
    {
        notfruit=-1,banana, apple, pear, count
    }
}
