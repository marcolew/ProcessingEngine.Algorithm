using System;
using System.ComponentModel;

namespace ProcessingEngine.Algorithm.Testconsole
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello Algorithm-World!");
			 ExampleImplementation.ExampleAlgorithm expl = new ExampleImplementation.ExampleAlgorithm ();

			//Configuration
			expl.LoopNumber=100;
			expl.SleepTime = 100;

			BackgroundWorker w = new BackgroundWorker();
			w.DoWork += (sender, e) => expl.Run();

			w.RunWorkerCompleted += (sender, e) => {
				Console.WriteLine("BackgroundTask completed");
				Console.WriteLine("Result " + expl.Output);
			};
			w.RunWorkerAsync ();

			Console.WriteLine ("Finished!");
			Console.ReadLine ();
		}
	}
}
