using System;
using System.Threading.Tasks;
using System.Threading;

namespace labs_72_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Old
            var ActionMethod01 = new Action(DoThis);
            var task01 = new Task(ActionMethod01);
            task01.Start();

            //Old
            //Hey computer, please create a background task, and whenever the CPU has resources available, run this task please.
            //CPU: hey, no problem.
            var task02 = Task.Factory.StartNew(
                
                () => 
                {
                    Thread.Sleep(10);
                    Console.WriteLine("Inside Task02 which is called by Task Factory");
                }
                );

            //Almost current
            var task03 = new Task(
                () => { Console.WriteLine("In Task 03"); }
                );
            task03.Start();

            //Do This way
            var task04 = Task.Run(
                () =>
                {
                    Console.WriteLine(("In Task 04 - use this way to create and run tasks"));
                    DoThis();
                }
                );
            //Hang the program so it doesn't terminate
            Console.WriteLine("Program has finished");
            System.Threading.Thread.Sleep(3000);
        }

        static void DoThis()
        {
            Thread.Sleep(10);
            Console.WriteLine("I am doing something");
        }
    }
}
