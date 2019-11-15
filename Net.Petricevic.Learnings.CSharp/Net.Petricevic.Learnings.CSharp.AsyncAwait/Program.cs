using System;
using System.Threading;

namespace Net.Petricevic.Learnings.CSharp.AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");

            var worker = new Worker();
            worker.DoWork();

            while (!worker.IsComplete)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            Console.WriteLine("Done");
        }
    }
}
