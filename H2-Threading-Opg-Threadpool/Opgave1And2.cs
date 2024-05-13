using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace H2_Threading_Opg_Threadpool
{
	internal class Opgave1And2
	{
        /// <summary>
        /// This code take long to execute for the assignment 2 
        /// </summary>
        public void Main()
		{
			Stopwatch mywatch = new Stopwatch();
			Console.WriteLine("Thread Pool Execution");
			mywatch.Start();
			ProcessWithThreadPoolMethod();
			mywatch.Stop();
			Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedTicks.ToString());


			mywatch.Reset();
			Console.WriteLine("Thread Execution");
			mywatch.Start();
			ProcessWithThreadMethod();
			mywatch.Stop();
			Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedTicks.ToString());
		}

		static void ProcessWithThreadPoolMethod()
		{
			for (int i = 0; i < 100000; i++)
			{
				for (int j = 0; j < 100000; j++)
				{
					ThreadPool.QueueUserWorkItem(Process);
				}
			}
		}

		static void ProcessWithThreadMethod()
		{
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                    Thread obj = new Thread(Process);
					obj.Start();
				}
            }
        }

		/* !Svar til opgaven!
		 * 
		 * Ja, Process()-metoden behøver ikke at tage et objekt som argument her.
		 * Fordi det ikke bruger objektet til noget som helst, og det vil kun gøre koden mere kompleks og sværere at forstå.
		 * Det er bare en god praksis at undgå unødvendige ting i vores kode.
		 * Så i dette tilfælde er det bedre at holde Process()-metoden enkel og uden argumenter.
		 */
		static void Process(object callback)
		{

		}
	}
}
