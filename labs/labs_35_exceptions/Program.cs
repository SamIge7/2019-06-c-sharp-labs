using System;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace labs_35_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try { }
            catch { }

            try {
                //var db = new Database...
                //db.Open
                //exception..
            }
            catch { }
            finally
            {
                // this will runn if exception or not eg close database
                //db.Close();
            }

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

                
            }
        
            finally { }
        }
    }
}
