using System;

namespace labs_23_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Grow() : Instance Method
            var x01 = new X();
            x01.Grow();
            // ReturnFixedData : Static Method 
            X.ReturnFixedData();

            // remember static maths class which returns pi, logx etc
            Console.WriteLine(Math.PI);
            DoThis();
            DoThis();
            DoThis();
            DoThat();
            DoingLots(100, "hi", true);
            DoingLots(c: false, b: "there", a: 100000000);

            // can put method here
            void DoThis() { Console.WriteLine("I am doing something"); }

            DoingSomeOtherWork(new DateTime(2019, 06, 27));   // set date but others default
            DoingSomeOtherWork(new DateTime(2019, 06, 27),'a', 1.3F, 100.234);   // set date but others default 
            
        }
        // can put method here
        static void DoThat() { Console.WriteLine("I am doing something else"); }

        static void DoingLots(int a, string b, bool c)
        {
            Console.WriteLine($"Doing lots {a}, {b}, {c}");

        }

        static void DoingSomeOtherWork(DateTime date, char c = 'z', float f = 1.2F, double d = 100.329)
        {
            Console.WriteLine($"{date}, {c}, {f}, {d}");
            string newday = date.ToShortDateString();
            Console.WriteLine($"{newday}, {c}, {f}, {d}");
            newday = date.ToLongDateString();

        }
        class X
        {
            public int Age;
            // can put instance methods here: instance = stock for user
            public void Grow()
            {
                Age++;
            }
            // static method: useful for more fixed data: static = stock for warehouse (whole app)
            public static string ReturnFixedData()
            {
                return "Here is some fixed data";
            }
        }
    }
}
