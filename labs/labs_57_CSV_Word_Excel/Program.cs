using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
namespace labs_57_CSV_Word_Excel
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Delete("output.csv");
            File.AppendAllText("output.csv", "Seconds,Rabbit Population\n");
            for(int i = 0; i<10; i++)
            {
                File.AppendAllText("output.csv", $"{i}, {Math.Pow(2,i)}\n");
            }
            Process.Start("output.csv");
        }
    }
}
