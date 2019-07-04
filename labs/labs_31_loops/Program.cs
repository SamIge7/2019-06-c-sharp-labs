using System;

namespace labs_31_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //count from 1 to 10
            // in each loop also count from 1 to 5
            /*
              
                1
                    1
                    2
                    3
                    4
                    5
                2
                    1
                    2
                    3
                    4
                    5
             * 
             * 
             * 
             */
             for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i is {i}");
                for (int j = 1; j <=5; j++)
                {
                    Console.WriteLine($"\t\tj is {j}");
                }
            }
        }
    }
}
