using System;
using System.Collections.Generic;
using System.Collections;

namespace labs_48_snaplab_loops
{
    public class Program
    {
         public static void Main(string[] args)
        {
            /*
               Snap Lab : 10 minutes
                Input 5 numbers and put into an ArrayList
                Create an Array, List, Queue, Stack, Dictionary.
                Move objects from Arraylist to each item and multiply by 4 each move.
                What's the total?
                Time starts 
             */
            int[] r = { 5, 6, 7, 8, 9 };
            Console.WriteLine(Loops(r));
        }

        
        


            public static int Loops(int[] myArray)
            {
                ArrayList list2 = new ArrayList { 5, 6, 7, 8, 9 };
                int[] array = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    array[i] = (int)list2[i] * 4;
                }

                List<int> list = new List<int>();

                foreach (var item in array)
                {
                    list.Add(item * 4);
                }

                var queue = new Queue<int>();

                foreach (var item in list)
                {
                    queue.Enqueue(item * 4);
                }

                var stack = new Stack<int>();

                foreach (var item in queue)
                {
                    stack.Push(item * 4);
                }

                var dictionary = new Dictionary<int, int>();
                int sum = 0;
                int counter = 0;
                foreach (var item in stack)
                {
                    dictionary.Add(counter, item * 4);
                    counter++;

                }

                foreach (var key in dictionary)
                {
                    sum += key.Value;
                }
                return sum;
            }
        
    }
}
