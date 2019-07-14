using System;
using System.IO;

namespace labs_44_exception_recursive
{
    class Program
    {
        public static int i;
        static void Main(string[] args)
        {
            
            string y = null;

            try
            {
                var filecontents = File.ReadAllText("youwon'tfindme.txt");
                Console.WriteLine(y.Length);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Null Reference");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Not Found");
            }
            catch (Exception e)
            {
                Console.WriteLine("General Exception");
            }
        }

        static void ExceptionRecursion()
        {
            i += 3;
            Console.WriteLine(i);
            ExceptionRecursion();
        }
    }
}
