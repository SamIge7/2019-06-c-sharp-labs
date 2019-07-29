using System;

namespace labs_59_abstract_revision
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = new FinalDetails();
            h.FlightDetails();
            h.HotelLocation();
            h.PlacesToGo();
            h.ResturantsToEat();
        }

        abstract class HaveAHolidayInParis
        {
            internal void HotelLocation() { Console.WriteLine("Right next to the Eiffel Tower"); }

            internal void FlightDetails() { Console.WriteLine("Fly from Heathrow on Sunday, Fly from Paris on Wednesday"); }

            public abstract void ResturantsToEat();

            public abstract void PlacesToGo();
        }

        class FinalDetails: HaveAHolidayInParis
        {
            public override void ResturantsToEat()
            {
                Console.WriteLine("Eat at the Hotel Resturant for the first few days, and then walk around and find resturants around the city");
            }

            public override void PlacesToGo()
            {
                Console.WriteLine("Eiffel Tower, Disneyland, Arc de Triomphe, Notre Dame");
            }
        }
    }
}
