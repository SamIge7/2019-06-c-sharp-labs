using System;
using System.Collections.Generic;
namespace snaplab_loops2
{
    public class Programme
    {
        public static void Main(string[] args)
        {
            int[] x = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            CodingLoop(x);
        }

        public static int CodingLoop(int[] array)
        {
            int[] array2 = new int[10];
            int counter = 1;
            for (int i = 0; i < 10; i++)
            {
                array2[i] = array[i]+counter;
                counter++;
            }

            var queue = new Queue<int>();
            foreach (var item in array2)
            {
                queue.Enqueue(item + counter);
                counter++;
            }

            var stack = new Stack<int>();
            foreach (var item in queue)
            {
                stack.Push(item + counter);
                counter++;
            }

            int counter2 = 0;
            var dictionary = new Dictionary<int, int>();
            foreach (var item in stack)
            {
                dictionary.Add(counter2, item + counter);
                counter++;
                counter2++;
            }

            List<int> list = new List<int>();
            foreach(var item in dictionary)
            {
                list.Add(item.Value + counter);
                counter++;
            }

            int sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            return sum;
        }
    }
}
