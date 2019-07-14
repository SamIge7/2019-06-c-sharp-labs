using System;
using System.Collections.Generic;
using System.Collections;
namespace labs_34_lists

{
    class Program
    {
        static List<int> list01 = new List<int>();
        static List<string> list02 = new List<string>();
        static List<int> list03 = new List<int>();
        static List<int> list04 = new List<int>();

        static void Main(string[] args)
        {
            //arrays are fixed
            var array01 = new int[10]; //size is fixed
            //2d array
            var Grid2D = new int[10, 10];
            var Cube3D = new int[5, 5, 5];
            var Grid4D = new int[10, 10, 10, 10];
            //the above arrays are all fixed in size

            //its possible to create an array of arrays where each array can be of a different size i.e. jagged arrays

            //jagged array
            int[][] jaggedArray01 = new int[3][];
            //first array size 10
            jaggedArray01[0] = new int[10];
            //second array size 100
            jaggedArray01[1] = new int[100];
            jaggedArray01[2] = new int[1000];

            //private scope inside method
            List<short> shortList = new List<short>();

            list01.Add(10); // index 0
            list01.Add(20); // index 1
            list01.Insert(0, 100); // index 0, push others along

            foreach (var item in list01)
            {
                Console.WriteLine($"{item}");
            }

            list01.RemoveAt(0);
            Console.WriteLine("\n\nRemove index 0\n\n");
            foreach (var item in list01)
            {
                Console.WriteLine($"{item}");
            }

            //list of string x 3
            //insert new item at index 1 and view result

            list02.Add("Good");
            list02.Add("there");
            list02.Add("Sam");
            list02.Insert(1, "morning");

            Console.WriteLine("\n\nString\n\n");
            foreach(var item in list02)
            {
                Console.WriteLine($"{item}");
            }

            //foreach block: use quite often

            var dictionary01 = new Dictionary<int, string>();
            dictionary01.Add(10, "hi");
            dictionary01.Add(20, "there");
            dictionary01.Add(30, "spartans");
            dictionary01.Add(40, "spartans2");
            dictionary01.TryAdd(40, "some value that won't be posted");

            // iterate - loop over the dictionary
            Console.WriteLine("\n\nDictionary\n\n");
            foreach (var key in dictionary01.Keys)
            {
                Console.WriteLine($"Key {key,-15} Value {dictionary01[key]}");
            }

            //queue
            var queue = new Queue<int>();
            queue.Enqueue(10); // add first item
            queue.Enqueue(20); // second item
            queue.Enqueue(30); // third item

            //...................30.....20....10...Bus Stop

           var itemWhichJustGotOnTheBus =  queue.Dequeue(); // first item gets on bus

            //........................30....20...Bus Stop

            Console.WriteLine($"item which just got on the bus is {itemWhichJustGotOnTheBus}");

            Console.WriteLine($"Queue contains number 50? {queue.Contains(50)}");
            Console.WriteLine($"Queue contains number 20? {queue.Contains(20)}");

            Console.WriteLine($"Check out who is first in line {queue.Peek()}");

            //iterate - print a foreach loop
            Console.WriteLine("\n\nFirst in Line\n\n");
            foreach (var item in queue)
            {
                Console.WriteLine($"The first person in line is {item}");
            }

            //stack
            Console.WriteLine("\n\nStack\n\n");
            var stack = new Stack<string>();

            stack.Push("first");
            stack.Push("second");
            stack.Push("third");
            stack.Push("fourth"); //LIFO

            foreach (var item in stack)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("\n\nRemove one item 'pop' off top\n\n");
            stack.Pop();

            foreach (var item in stack)
            {
                Console.WriteLine(item);

            }

            //contains
            Console.WriteLine($"Stack contains third? {stack.Contains("third")}");
            Console.WriteLine($"Stack contains first? {stack.Contains ("first")}");

            //peek
            Console.WriteLine($"Check out who is in the stack {stack.Peek()}");

            //take numbers as an array 10 20 30 40
            var NumArray = new int[] { 10, 20, 30, 40 };

            //create a list, multiply by 10
            Console.WriteLine("\n\nMultiply by 10\n\n");
            foreach (var item in NumArray)
            {
                list03.Add(item*10);
            }
            //create a queue, add 1
            var queue02 = new Queue<int>();

            foreach (var item in list03)
            {
                queue02.Enqueue(item + 1);
            }
            //create a stack, add 2
            var stack02 = new Stack<int>();
            int sum = 0;
            foreach (var item in queue02)
            {
                stack02.Push(item + 2);
            }
            //what's the sum?
            foreach (var item in stack02)
            {
                sum += item;
            }
            Console.WriteLine(sum);
            Console.ReadLine();

            var NumArray2 = new int[] { 20, 40, 60, 80, 100 };

            foreach(var item in NumArray2)
            {
                list04.Add(item * 10);
            }

            var queue04 = new Queue<int>();
            foreach(var item in list04)
            {
                queue04.Enqueue(item + 1);
            }

            var stack04 = new Stack<int>();
            foreach(var item in queue04)
            {
                stack04.Push(item + 2);
            }

            foreach (var item in stack04)
            {
                sum += item;
            }
            Console.WriteLine(sum);

            Console.WriteLine("\n\nArrayList\n\n");
            var objectList = new ArrayList();
            objectList.Add(10);
            objectList.Add("hi");
            objectList.Add(true);
            objectList.Add(DateTime.Now);

            foreach(var item in objectList)
            {
                Console.WriteLine($"{item.GetType(), -20}{item}");
            }
        }

        void DoThis() {
            list01.Add(10);
            list02.Add("hi");
            //shortlist invisible
        }
        void DoThat() { }
    }
}
