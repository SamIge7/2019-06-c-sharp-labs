using System;

namespace labs_62_events_trivial
{
    class Program
    {
        //Declare delgate (restriction on method types)
        public delegate int Delegate01(string x);
        //Declare an event
        public static event Delegate01 Event01;
        static void Main(string[] args)
        {
            //1) Declared an event

            //2) Declared the restriction on method types (delegate)

            //3 Add a Method
            Event01 += Method01; //No brackets, so placeholder created, but method not called 
            Event01("Hello World, Special Event");
        }

        static int Method01(string input)
        {
            Console.WriteLine("Hey, are you printing something?");
            Console.WriteLine(input);
            return input.Length;
        }
    }
}
