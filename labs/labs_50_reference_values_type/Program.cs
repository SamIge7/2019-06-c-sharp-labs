using System;

namespace labs_50_reference_values_type
{
    class Program
    {
        static void Main(string[] args)
        {
            //value types
            int x = 10;
            int y = x;
            y = 100;
            Console.WriteLine($"x is {x} and y is {y}");

            // reference types
            int[] a = new int[] { 10, 20, 30 };
            int[] b = a;
            //for every item in an array (array_name, do this)

            //do this can be written in Lambda form

            //Lambda form (parameter int => Method out)

            //if Method is one line Method, can omit braces
            Console.WriteLine("\n\nBefore changes\n");
            Array.ForEach(a, item => Console.WriteLine(item));
            Array.ForEach(b, item => Console.WriteLine(item));

            a[2] = 578;

            Console.WriteLine("\n\nAfter changes\n");
            Array.ForEach(a, item => Console.WriteLine(item));
            Array.ForEach(b, item => Console.WriteLine(item));

            var c = (int[])a.Clone();

            Console.WriteLine("\n\nAfter cloning\n");
            Array.ForEach(a, item => Console.WriteLine(item));
            Array.ForEach(b, item => Console.WriteLine(item));
            Array.ForEach(c, item => Console.WriteLine(item));



        }
    }
}
