using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Threading_Opg_Threadpool
{
	internal class Opgave3
    {
        /*!Som svar til opgave 3!
         * 
         1 - Start():
        Starts the execution of the thread.
        2 - Sleep():
        Suspends the current thread's execution for a specified amount of time.
        3 - Suspend():
        Suspends the execution of the thread.
        4 - Resume():
        Resumes the execution of a suspended thread.
        5 - Abort():
        Aborts the execution of the thread, causing a ThreadAbortException to be thrown.
        6 - Join():
        Blocks the calling thread until the thread terminates.
        */


        public void Main()
        {
            // Create and start a custom thread pool with 3 threads
            int threadCount = 3;

            // Create an array to hold the threads
            Thread[] threads = new Thread[threadCount];

            // Start all threads in the thread pool
            for (int i = 0; i < threadCount; i++)
            {
                threads[i] = new Thread(ThreadTask);
                threads[i].Start();
            }

            // Wait for all threads to finish
            for (int i = 0; i < threadCount; i++)
            {
                threads[i].Join();
            }

            Console.WriteLine("All threads have finished. Press Enter to exit...");
            Console.ReadLine();
        }

        static void ThreadTask()
        {
            // Print thread information
            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"IsAlive: {Thread.CurrentThread.IsAlive}");
            Console.WriteLine($"IsBackground: {Thread.CurrentThread.IsBackground}");
            Console.WriteLine($"Priority: {Thread.CurrentThread.Priority}");

            // Simulate a long-running task
            Thread.Sleep(1000);
        }
    }
}
