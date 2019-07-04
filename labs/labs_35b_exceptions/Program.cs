using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace labs_35b_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //potentially dodgy code here
                var data01 = File.ReadAllText("thisfiledoesnotexist.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception was thrown and caught here");
                Console.WriteLine("Details are: ");
                Console.WriteLine(e);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
                Console.WriteLine("You are an amazing user and you are using this program beautifully");
                Console.WriteLine("We can't find that file for you however!");

                var d = DateTime.Now;
                //log exception
                File.AppendAllText("logoutput.txt", $"Exception at {d} - file not found");

                EventLog.WriteEntry("Application", "Sam Ige is in Windows", EventLogEntryType.Information, 5001, 1234);
            }

            finally { }



            Console.WriteLine("\n\nLook At DivideByZero Exception Also\n\n");

            int x = 10;
            int y = 0;
            //throw and catch x/y and output "you divided by zero"
            try
            {
                int num = x / y;

            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("You divided by zero");
            }
        }
    }
}
