﻿using System;

namespace lab_40_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for: fixed number of iterations

            //foreach : every item in array/collection

            //while (condition chekced before loop, may never enter)

            //do..while (condition checked after loop, always enters at least once)

            //break: useful when looking for 1 item only and looping until we find this item

            string[] items = new string[] { "first", "second", "third" };
            foreach(var item in items)
            {
                if(item == "second")
                {
                    break;  //exit foreach loop completely
                }
                Console.WriteLine("items before break point - " + item);  // first only
            }

            //continue

            foreach (var item in items)
            {
                if (item == "second")
                {
                    continue;  //finish this loop and start on next loop
                }
                Console.WriteLine("items not including continue - " + item); 
            }

            //return
            //use return to save lots of if..else conditions and nesting
            var output = DoThis(10);

            int DoThis(int inputnumber)
            {
                if (inputnumber == 5)
                {
                    return -100;
                }
                if (inputnumber == 10)
                {
                    return -150;
                }
                return -1000;
            }
            Console.WriteLine(output);

            //throw
            //Create loop but manually create exception and exit loop if certain conditions reached
        }
    }
}
