using System;

namespace labs_30_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //pass in an integer
            //a) output a left-justified pyramid
            //4
            /*
                *   
                * *
                * * *
                * * * *
             * 
             * 
              b) Bonus: centre-justified pyramid
              4
                        *
                       * *
                      * * *
                     * * * *
               */

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
        }
    }
}
