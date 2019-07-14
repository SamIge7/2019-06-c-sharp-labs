using System;
using System.Collections.Generic;
using System.Linq;

namespace labs_45_snaplabs_structs
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>();
            List<int> xValues = new List<int>();
            List<int> yValues = new List<int>();
            var p1 = new Point (1, 4); 
            var p2 = new Point (4, 7); 
            var p3 = new Point (7, 10);
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            foreach (var item in points)
            {
                xValues.Add(item.X);
                yValues.Add(item.Y);
            }
            var xValuesArray = xValues.ToArray();
            var yValuesArray = yValues.ToArray();

            Console.WriteLine("Max X Value " + xValuesArray.Max());
            Console.WriteLine("Max Y Value " + yValuesArray.Max());
            Console.WriteLine("Min X Value " + yValuesArray.Min());
            Console.WriteLine("Min Y Value " + yValuesArray.Min());

            Console.WriteLine("X Value Range is " + (xValuesArray.Max() - xValuesArray.Min()));
            Console.WriteLine("Y Value Range is " + (yValuesArray.Max() - yValuesArray.Min()));

           
        }

        
        public struct Point
        {
            public int X;
            public int Y;

            public Point (int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            
            

        }
    }
}
