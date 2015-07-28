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
			expl.Input = 10;

			Console.WriteLine ("INPUT PROPERTIES");
			foreach (var inp in expl.InputProperties)
			{
				Console.WriteLine (inp.ToString ());
			}

			Console.WriteLine ("PARAMETER PROPERTIES");
			foreach (var par in expl.ParameterProperties)
			{
				Console.WriteLine (par.ToString ());
			}

			Console.WriteLine ("OUTPUT PROPERTIES");
			foreach (var oup in expl.OutputProperties)
			{
				Console.WriteLine (oup.ToString ());
			}

			Console.WriteLine("Result (before processing) " + expl.Output);

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
