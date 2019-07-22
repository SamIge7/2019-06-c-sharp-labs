using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
namespace NHS_Interview_Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymoprhism
            var p = new Parent();
            p.Holiday();
            var y = new YoungChild();
            y.Holiday();
            var t = new Teenager();
            t.Holiday();

            //Abstraction
            var dayout = new StuffToSort();
            dayout.Location();
            dayout.Date();
            dayout.Itinerary();
            dayout.PeopleComing();

            //Primitive Types
            Console.WriteLine("\n\n====Primitive Types====\n\n");
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);

            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);

            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ushort.MinValue);

            //Decimals
            Console.WriteLine("\n\n====Decimals====\n\n");
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            
            //Stopwatch
            Console.WriteLine("\n\n====Starting The Stopwatch===\n");
            var s = new Stopwatch();
            s.Start();
            int counter = 0;
            for (int i = 0; i < 1000000; i++)
            {
                counter++;
            }
            s.Stop();
            Console.WriteLine(s.ElapsedTicks);
            Console.WriteLine(s.ElapsedMilliseconds);
            Console.WriteLine(s.Elapsed);

            //Date
            var time1 = DateTime.Now;
            Console.WriteLine(time1.DayOfWeek + " " + time1.ToLongDateString());
            Console.WriteLine(time1.ToLongDateString());
            Console.WriteLine(time1.ToShortDateString());
            //Add 1 day
            Console.WriteLine("\n\n====Adding 1 day====\n");
            Console.WriteLine(time1.AddDays(1));
            //Add 1 hour
            Console.WriteLine("\n\n====Adding 1 hour====\n");
            Console.WriteLine(time1.AddHours(1));
            //Add 1 second
            Console.WriteLine("\n\n====Adding 1 second====\n");
            Console.WriteLine(time1.AddSeconds(1.0));
            //Adding 1 Millisecond
            Console.WriteLine("\n\n==Adding 1 millisecond====\n");
            Console.WriteLine(time1.AddMilliseconds(1).ToLongTimeString());
            //Adding 1 Tick
            Console.WriteLine("\n\n====Adding 1 tick====\n");
            Console.WriteLine(time1.AddTicks(1).ToLongTimeString());

            //Int.TryParse
            Console.WriteLine("\n\n====Int.TryParse====\n");
            int.TryParse("123456", out int output01);
            Console.WriteLine(output01);
            //Float.TryParse
            Console.WriteLine("\n\n====Float.TryParse====\n");
            float.TryParse("123.456", out float output02);
            Console.WriteLine(output02);

            //Enum
            Console.WriteLine("\n\n====Enum====\n\n");
            Console.WriteLine((int)Sweets.Rowntree);
            Console.WriteLine((int)Sweets.Haribo);

            //Struct
            Console.WriteLine("\n\n====Structs====\n");
            var a1 = new Area(15, 30, 15);
            var a2 = new Area(25, 50, 20);
            var a3 = new Area(40, 10, 20);

            //Print Array
            Console.WriteLine("\n\n====Print Array====\n");
            var array = new int[10] { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 };
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }

            //2D Grid Print
            Console.WriteLine("\n\n====2D Grid Print====\n");
            long[,] arr = new long[10, 10];
            for (int x1 = 0; x1 < 10; x1++)
            {
                for (int y1 = 0; y1 < 10; y1++)
                {
                    Console.Write(arr[x1, y1]);
                }
                Console.Write(Environment.NewLine, Environment.NewLine);
            }

            //3D Grid Print
            Console.WriteLine("\n\n====3D Grid Print====\n");
            long[,,] array2 = new long[10, 10, 10];
            for (int x2 = 0; x2 < 10; x2++)
            {
                for (int y2 = 0; y2 < 10; y2++)
                {
                    for (int z2 = 0; z2 < 10; z2++)
                    {
                       Console.Write(array2[x2, y2, z2]);
                       //array2[x2, y2, z2] = x2 * y2 * z2;
                       //Console.WriteLine(array2[x2,y2,z2].ToString());
                    }
                    Console.Write(Environment.NewLine, Environment.NewLine);
                }
                Console.Write(Environment.NewLine, Environment.NewLine);
            }
            //Array -> List -> Queue -> Stack -> Dictionary
        }
        //Inheritance
        public class Mammal
        {
            public int Height { get; set; }
            public int Weight { get; set; }
            public string Name { get; set; }
        }

        public class Rabbit: Mammal
        {

        }

        //Encapsulation
        public class Dog : Mammal
        {
            private int Height { get; set; }
            private int Weight { get; set; }
            private int Length { get; set; }
            public string DogName { get; set; }
        }

        //Polymorphism
        public class Parent
        {
            public virtual void Holiday()
            {
                Console.WriteLine("We want to go on holiday to Paris!");
            }
        }

        public class YoungChild : Parent
        {
            public override void Holiday()
            {
                Console.WriteLine("We want to go to DisneyLand for our holiday!");
            }
        }

        public class Teenager : Parent
        {
            public override void Holiday()
            {
                Console.WriteLine("I want to go to Amsterdam for our holiday!");
            }
          
        }

        //Abstraction
        abstract class DayOut
        {
            internal void Location() {Console.WriteLine("Sorted");}
            internal void Date() {Console.WriteLine("Sorted");}
            public abstract void Itinerary();
            public abstract void PeopleComing();
        }

        class StuffToSort : DayOut
        {
            public override void Itinerary() { Console.WriteLine("Watch a sports match, go out for some food and chill at the beach"); }
            public override void PeopleComing() { Console.WriteLine("Steve and his girlfriend, Billie and Jerome"); }
        }

        //Enum
        enum Sweets
        {
            sweet = -1,Haribo, Maynards, Rowntree
        }

        //Struct
        public struct Area
        {
            public int Length;
            public int Height;
            public int Width;

            public Area (int length, int height, int width)
            {
                this.Length = length;
                this.Height = height;
                this.Width = width;
            }
        }

        //Array -> List -> Queue -> Stack -> Dictionary
        public static int ContainerChange (int[] array)
        {
            ArrayList arraylist = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] array3 = new int[10];
            for (int z = 0; z < 10; z++)
            {
                array3[z] = (int)arraylist[z];
            }

            List<int> list = new List<int>();
            foreach (var item in array3)
            {
                list.Add(item);
            }

            var queue = new Queue<int>();
            foreach(var item in list)
            {
                queue.Enqueue(item);
            }

            var stack = new Stack<int>();
            foreach (var item in queue)
            {
                stack.Push(item);
            }

            var dictionary = new Dictionary<int, int>();
            int sum = 0;
            int counter = 0;
            foreach (var item in stack)
            {
                dictionary.Add(counter, item);
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
