using System;
using System.Collections;

namespace labs_41_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Cast
            //useful for when it is impossible for data to be lost
            //from int 1 to double 1.0
            int num01 = 100;
            double d01 = num01;

            //Explicit Cast
            //Required when data will definitely be lost
            // double 2.134 to int 2: truncate 0.134
            double d02 = 2.134;
            int num02 = (int)d02;
            Console.WriteLine($"{d02} has become {num02}");

            //Is
            var p = new Parent();
            var c = new Child();
            if (c is Parent)
            {
                Console.WriteLine("Your child is a member of the parent family");
            }
            //Don't really use this as exceptions can occur if it fails

            if (!(c is AnotherParent))
            {
                Console.WriteLine("C is not related to another parent!");
            }

            //As
            //cast from one type to another
            var p02 = new Parent();
            var c02 = new Child();
            var parentOfChild2 = c02 as Parent; ///safer as returns null if it fails
            var parentOfChild2v2 = (Parent)c02;

            //this will not work
            //var AnotherParent = c02 as AnotherParent;

            //Boxing and Unboxing

            var o = new Object(); //root of all objects
            int i = 10;
            //may have a structrue dealing with multiple objects
            //will have to 'cast' from a type to general objects
            int num03 = 100;
            var o3= num03;   //'box' integer as an 'object'
            //when finished, cast back to number
            int num04 = (int)03;    //get back our integer


            //ArrayList: list of objects of no fixed type.
            var mixedlist = new ArrayList();
            mixedlist.Add(10);
            mixedlist.Add("hello");
            mixedlist.Add(DateTime.Now);
            mixedlist.Add(10.01);
            foreach (var item in mixedlist)
            {
                Console.WriteLine($"{item} is an {item.GetType()}");

            }
        }
    }

    class Parent { }

    class Child : Parent { }

    class AnotherParent { }
}
