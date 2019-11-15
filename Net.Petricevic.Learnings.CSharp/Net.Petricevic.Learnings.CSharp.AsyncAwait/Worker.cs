using System;
using System.Threading;
using System.Threading.Tasks;

namespace Net.Petricevic.Learnings.CSharp.AsyncAwait
{
    /// <summary>
    /// Based on https://www.youtube.com/watch?v=6_GTdR0gBVE
    /// </summary>
    internal class Worker
    {
        public bool IsComplete { get; private set; }

        public async void DoWork()
        {
            IsComplete = false;
            Console.WriteLine("Doing work.");

            await LongOperation();

            Console.WriteLine("Work completed.");

            IsComplete = true;
        }

        private Task LongOperation()
        {
            return Task.Factory.StartNew(() => 
            {
                Console.WriteLine("Working...");
                Thread.Sleep(2000);
            });
        }
    }
}