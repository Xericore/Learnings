using System;
using System.Threading;
using System.Threading.Tasks;

namespace Net.Petricevic.Learnings.CSharp.Tasks
{
    // Example from https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task?view=netcore-3.0
    class Program
    {
        static void Main(string[] args)
        {
            Action<object> action = (object obj) =>
            {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}", Task.CurrentId, obj, Thread.CurrentThread.ManagedThreadId);
            };

            // Create a task but don't start it
            Task t1 = new Task(action, "alpha");

            // Construct a started task
            Task t2 = Task.Factory.StartNew(action, "beta");
            // Block the main thread to demonstrate that t2 is executing
            t2.Wait();

            // Launch t1
            t1.Start();
            Console.WriteLine($"t1 has been launched. (Main thread={Thread.CurrentThread.ManagedThreadId})");
            t1.Wait();

            // Construct a started task using Task.Run
            string taskData = "delta";
            Task t3 = Task.Run(() =>
            {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}", Task.CurrentId, taskData, Thread.CurrentThread.ManagedThreadId);
            });
            t3.Wait();

            // Construct an unstarted task
            Task t4 = new Task(action, "gamma");
            t4.RunSynchronously();
            // Although the task was run synchronously, it's a good practice 
            // to wait for it in the even exection were thrown by the task.
            t4.Wait();

        }
    }
}
