using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace labs_61_debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine(i);
                Debug.WriteLine($"Debugging: i is {i}");
                Trace.WriteLine($"Trace to Output window (in final release mode and debug mode): i is {i}");
                File.AppendAllText("output.txt",$"Logging to Text file {DateTime.Now} i has value {i}");

                var output = $"Logging to text file {DateTime.Now} i has value {i}";
                //log to c:\Log folder
                File.AppendAllText("C:\\Log\\output.txt", output + Environment.NewLine);
                //log to My Documents\Log folder
                File.AppendAllText("C:\\Users\\sige\\Documents\\Log\\output2.text", output + Environment.NewLine);
                // @ Literal string notation as well
                File.AppendAllText(@"C:\Users\sige\Documents\Log\output3.text", output + Environment.NewLine);
                //Any Users?
                File.AppendAllText(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Log\\output.txt", output + Environment.NewLine);
                //can also log to the Windows Application Event Log
                EventLog.WriteEntry("Application", "output", EventLogEntryType.Information, 5678, 123);
            }
            EventLog.WriteEntry("Application", "Your Windows has been Hacked", EventLogEntryType.Information, 5678, 123);

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine($"J has a value of {j}");
            }
            Console.ReadLine();
            //1 ==> debug which is F5
            //2 ==> not debug mode which is Control F5
            //3 ==> not debug mode plus build => Configuration => Release then only shows trace output

            //Debugging
            /*
             
             */
        }
    }
}
