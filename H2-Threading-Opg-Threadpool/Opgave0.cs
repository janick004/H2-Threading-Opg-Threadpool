using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Threading_Opg_Threadpool
{
	internal class ThreadPoolDemo
	{
		// Method to perform task 1
		public void task1(object obj)
		{
			// Loop runs 3 times
			for (int i = 0; i <= 2; i++)
			{
				// Prints task 1 execution message
				Console.WriteLine("Task 1 executing");
			}
		}

		// Method to perform task 2
		public void task2(object obj)
		{
			// Loop runs 3 times
			for (int i = 0; i <= 2; i++)
			{
				// Prints task 2 execution message
				Console.WriteLine("Task 2 executing");
			}
		}


		public void Main()
		{
			// Creates an instance of ThreadPoolDemo
			ThreadPoolDemo tpd = new ThreadPoolDemo();

			// Queues task 1 and task 2 to thread pool, twice
			for (int i = 0; i < 2; i++)
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.task1));
				ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.task2));
			}

			// Waits for user input
			Console.Read();
	}

	}
}
