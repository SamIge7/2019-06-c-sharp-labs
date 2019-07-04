using System;
using System.Collections.Generic;

namespace labs_16_rabbit
{
    class Program
    {
        static List<Rabbit> rabbits = new List<Rabbit>();
        static void Main(string[] args)
        {
            for (int i = 1; i<8; i++)
            {
                Console.WriteLine("Loop" + i);
                foreach (Rabbit r in rabbits)
                {
                    r.Age++;
                    Console.WriteLine($"At Loop {i}, {r.Name} is {r.Age}");
                }
                System.Threading.Thread.Sleep(200);
                var rabbit = new Rabbit(i);
                rabbits.Add(rabbit);
                //Rabbit is the Class (Blueprint)
                //rabbit is the actual real rabbit we create from class

                //To Print one by one
                Console.WriteLine($"{rabbit.Name,-20}{rabbit.Age}");
                
            }
            Console.WriteLine("\n\nPrinting All Rabbits\n\n");

            // Print all the rabbits at once after a delay
            foreach(var rabbit in rabbits)
            {
                Console.WriteLine($"{rabbit.Name,-20}{rabbit.Age}");
            }

        }
    }

   

}
 public class Rabbit
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Rabbit(int i)
        {
            this.Age = 0;
            this.Name = "Rabbit" + i;
        }
        
    }