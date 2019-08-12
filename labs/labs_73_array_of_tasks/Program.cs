using System;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace labs_73_array_of_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            s.Start();
            var taskArray = new Task[3];
            taskArray[0] = Task.Run(() => { Thread.Sleep(100);
                Console.WriteLine($"Task 0 done at {s.ElapsedMilliseconds}");
            });
            taskArray[1] = Task.Run(() => { Thread.Sleep(50);
                Console.WriteLine($"Task 1 done at {s.ElapsedMilliseconds}");
            });
            taskArray[2] = Task.Run(() => { Thread.Sleep(75);
                Console.WriteLine($"Task 2 done at {s.ElapsedMilliseconds}");
                var taskNested = Task.Run(() => { Console.WriteLine("nested task within task 2"); });
            });

            //Wait for one to terminate first
            Task.WaitAll(taskArray);

            //hang
            //Thread.Sleep(150);
            Console.WriteLine($"Tasks terminated at {s.ElapsedMilliseconds}");
            Console.ReadLine();

            // return data from a task
            // this is done with Generics where we say task (Task<T> => T is the data type to return)
            var taskGiveMeDataBack = Task<string>.Run(
                () => { Console.WriteLine("Task is running"); return "Task has completed!"; }
                );
            Console.WriteLine(taskGiveMeDataBack.Result);
        }
    }
}
