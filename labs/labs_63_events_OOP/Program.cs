using System;

namespace labs_63_events_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Scenario: Child will have birthday
                        Birthday is the EVENT
                        HaveAParty is the METHOD
                        We attach an OOP instance ie var james = new Child();
             */
            var James = new Child();
           for (int i = 1; i < 15; i++)
            {
                James.Grow();
            }
        }
    }

    class Child
    {
        public delegate int BirthdayDelegate(); //matches HaveAParty()
        public event BirthdayDelegate OneMoreYearOlder;
        public int Age { get; set; }

        public Child()
        {
            Age = 0;
            Console.WriteLine($"Congratulations on the birth of your new baby! Age is {Age}");
            OneMoreYearOlder += HaveAParty;
        }

        public void Grow()
        {
            OneMoreYearOlder();
        }

        public int HaveAParty()
        {
            Age++;
            Console.WriteLine($"Celebrating Birthday: Age is now {Age}");
            return Age;
        }
    }
}
