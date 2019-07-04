using System;
using System.Linq; //Talk to database

namespace labs_42_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operators: operate on one or more variables to produce a result

            //Unary

            //Incremental (prefix and postfix)

            //x++;
            int x01 = 100;
            int y01 = x01++; // y = 100, x = 101
            //y=x then increment x

            //++x;
            int x02 = 100;
            int y02 = ++x02; // y = 101, x = 101
            //increment x then y=x

            //safe rule is to only use x++; on one line with nothing else

            //Binary

            //modulus
            Console.WriteLine(100 % 8); // 4 (remainder)
            //whole number after division
            Console.WriteLine(100 / 8);// 12

            //&& AND:
            Console.WriteLine(1 & 1);
            Console.WriteLine(1 & 0);
            Console.WriteLine(0 & 1);
            Console.WriteLine(0 & 0);

            // | OR
            Console.WriteLine(1 | 1);
            Console.WriteLine(0 | 1);
            Console.WriteLine(1 | 0);
            Console.WriteLine(0 | 0);

            // ^ XOR
            Console.WriteLine(1 ^1);
            Console.WriteLine(0 ^1);
            Console.WriteLine(1 ^0);
            Console.WriteLine(0 ^0);

            // && and || save time if right hand side takes time to evaluate
            Console.WriteLine(false && DoThisLongOperation());

            //Bit shift (helps us to understand computers)

            //1010 in Binary = 10 in decimal
            //1101 in Binary = 13 in decimal
            //1010 to 10100 = 10 to 20
            //10100 to 101000 = 20 to 40
            //1010 to 101 = 10 to 5
            //101 to 10 = 5 to 2 (dangerous truncation)
            Console.WriteLine(8 >> 2); // move two places smaller
            Console.WriteLine(8 << 2); // moves two places bigger

            //Ternary

            int num04 = 100;
            int num05 = 1000;
            if (num04>num05)
            {
                //do this
            }
            else
            {
                //do that
            }

            //Ternary  : ?
            //var output = (condition)? "if true": "If false";
            var output = (num04 > num05) ? "high" : "low";
            Console.WriteLine(output);
            //can be confusing so only use if super confident

            //Lamda operator
            int[] myArray = { 1, 2, 3 };
            var outputArray01 = myArray.Where(item => item > 2);
            foreach(var item in outputArray01)
            {
                Console.WriteLine(item);
            }

            int?[] myArray2 = { null, 2, 3, null, 5, 6, null };

        }

        static bool DoThisLongOperation()
        {
            for (int i = 0; i < 100_000_000_000; i++)
            {
                Console.WriteLine(i);
            }
            return false;
        }

        
    }


}
