using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Sam!");

            var f = 1.23F;
            Console.WriteLine(f);
            var f02 = 1.4567456745674567;
            Console.WriteLine(f02);

            // use with exponential numbers =
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            // highest degree of precision in calculations
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            //Take extreme care when equating double numbers
            var d01 = 0.1;
            var d02 = 0.2;
            Console.WriteLine(d01+d02 == 0.3);

            //Take extreme care when equating double numbers
            var d03 = 0.1M;
            var d04 = 0.2M;
            Console.WriteLine(d03 + d04 == 0.3M);

            //test less than  small number
            Console.WriteLine((d01+d02-0.3)<0.000001);

            Console.ReadLine();
        }
    }
}
