using System;

namespace labs_21_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //var holiday = new HolidayIdea();  
            var holiday = new LetsGo();
            holiday.Transport();
            holiday.Itinerary();
            holiday.Location();
            holiday.Dates();
        }
    }

    abstract class HolidayIdea
    {
        internal void Location() { Console.WriteLine("sorted"); }
        internal void Dates() { Console.WriteLine("sorted"); }
        public abstract void Itinerary();
        public abstract void Transport();
    }

    class LetsGo : HolidayIdea
    {
        public override void Itinerary() { Console.WriteLine("see the sights"); }
        public override void Transport() { Console.WriteLine("fly, bus, train, walk"); }
    }
}
