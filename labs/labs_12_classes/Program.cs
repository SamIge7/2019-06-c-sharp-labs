using System;
using System.Collections.Generic;
namespace labs_12_classes
{
    class Program
    {
        static List<Dog> dogs = new List<Dog>();
        static void Main(string[] args)
        {
            var m01 = new Mammal();
            m01.Height = 100;
            m01.Weight = 2000;
            m01.Length = 150;
            var d01 = new Dog();
            d01.Weight = 80;
            d01.Length = 50;
            d01.Height = 1000;
            d01.DogID = "dog01";
            Console.WriteLine($"Dog has height {d01.Height}, weight {d01.Weight} and "+ $"length {d01.Length}");
            for (int i = 1; i<=20; i++)
            {
                //create dogs
                Dog newdog = new Dog();
                newdog.DogID = $"dog {i}";
                newdog.Length = 100;
                newdog.Height = 50;
                newdog.Weight = 30;
                // add dog to list of dogs
                dogs.Add(newdog);
                Console.WriteLine(newdog.ToString());
                // Console.WriteLine("ID is dog{0}", i); for new dogIDs
            }
            //print all dogs
            foreach(var dog in dogs)
            {
                Console.WriteLine($"{dog.DogID} has length{dog.Length}, height{dog.Height}, and weight{dog.Weight}");
            }
        }
    }

    class Dog : Mammal { }

    class Cat : Mammal { }

    class Mammal {
        public int Height;
        public int Weight;
        public int Length;
        public string DogID;
    }
}
