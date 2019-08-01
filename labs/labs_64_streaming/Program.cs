using System;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace labs_64_streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            s.Start();
            //stream to write a file
            using (var writer = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < 10000; i++)
                {
                    writer.WriteLine($"Line {i} - adding some text {DateTime.Now}: elapsed time {s.ElapsedTicks}");
                }
            }

            var t = new Stopwatch();
            t.Start();
            var stringbuilder = new StringBuilder();
            for (int i = 0; i<10000; i++)
            {
                stringbuilder.AppendLine($"Line {i} - adding some text {DateTime.Now}: elapsed time {t.ElapsedTicks}\n\n");
            }

            using (var writer = new StreamWriter("output2.txt"))
            {
                writer.WriteLine(stringbuilder);
            }
            t.Stop();

            var u = new Stopwatch();
            u.Start();
            string nextline;
            var stringbuilder2 = new StringBuilder();
            using (var reader = new StreamReader("output.txt"))
            {
                while((nextline=reader.ReadLine())!= null)
                {
                    stringbuilder2.AppendLine(nextline);
                }
            }
            Console.WriteLine($" read file to memory: {u.ElapsedTicks}");
            Console.ReadLine();
            Console.WriteLine(stringbuilder2);
            Console.WriteLine($"output file to console: {u.ElapsedMilliseconds}");
            u.Stop();

            //streaming to memory (used eg in encryption)
            //use a 'pointer' which is a reference to an address in memory
            //read data from pointer onwards

            using(var memorystream = new MemoryStream())
            {
                var buffer = new byte[100];
                buffer[0] = (int)'h';
                buffer[1] = (int)'e';
                buffer[2] = (int)'l';
                buffer[3] = (int)'l';
                buffer[4] = (int)'o';

                //write data to memory stream
                memorystream.Write(buffer);
                memorystream.Flush(); // actibvely push remaining data to memory

                //get meaningful data back?
                //reset pointer to 0
                memorystream.Position = 0;
                var reader = new StreamReader(memorystream);
                Console.WriteLine(reader.ReadToEnd());
               
            }
            
        }
    }
}
