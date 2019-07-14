using System;
using System.IO;
using System.Diagnostics;
using System.Text;
namespace labs_51_async
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            using (var writer = new StreamWriter("Data.dat"))
            {
                writer.WriteLine($"{counter,-5} new line {DateTime.Now}");
                writer.WriteLine($"{counter,-5} new line {DateTime.Now}");
                writer.WriteLine($"{counter,-5} new line {DateTime.Now}");
                for (int i =0; i < 1000000; i++)
                {
                    writer.WriteLine($"{i,5} new line {DateTime.Now}");
                }

            }

            ReadDataSync();
            ReadDataAsync();
            while (true)
            {
                System.Threading.Thread.Sleep(100);
                Console.WriteLine("Main Loop Working!");
            }
        }

        static void ReadDataSync()
        {
            var s = new Stopwatch();
            s.Start();
            //using can encapsulate a method which is reaching outside of the clean C# runtime.
            //Reading a file from Windows/Database SQL read
            //include a 'close()' method in it.

            //Stringbuilder can be used to easily construct a long string from lots of little inputs.
            var stringbuilder = new StringBuilder();
            //string longstring = "";
            using (var reader = new StreamReader("data.dat"))
            {
                while(!reader.EndOfStream)
                {
                    stringbuilder.Append(reader.ReadLine());
                    //longstring += reader.ReadLine();
                }
            }
            s.Stop();
            Console.WriteLine($"Reading 10,000,000 lines took {s.ElapsedMilliseconds}");
            System.Threading.Thread.Sleep(1000);
        }

        async static void ReadDataAsync()
        {
            using (var reader = new StreamReader("data.dat"))
            {
                var s = new Stopwatch();
                s.Start();
                string line = null;
                var stringbuilder = new StringBuilder();
                while(true)
                {
                    line = await reader.ReadLineAsync();
                    if (line == null)
                    {
                        break;
                    }
                    stringbuilder.Append(line);
                }
                s.Stop();
                Console.WriteLine(s.ElapsedMilliseconds);
            }
            
        }
    }
}
