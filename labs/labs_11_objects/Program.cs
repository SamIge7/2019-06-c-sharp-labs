using System;

namespace labs_11_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = new Object();
            Console.WriteLine(o);
            Console.WriteLine(o.ToString());

            //manually create and populate object
            Object o2 = new
            {
                name = "Sam",
                age = 22
            };

            Console.WriteLine(o2.ToString());

        }
    }
}
