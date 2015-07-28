using System;

namespace ProcessingEngine.Algorithm.ExampleImplementation
{
	[Serializable]
	public class ExampleAlgorithm: Algorithm
	{
		[ParameterAttribute("Number of Loops")]
		public int LoopNumber { get; set;}

		[ParameterAttribute("Milliseconds to Sleep")]
		public int SleepTime { get; set;}

		[InputAttribute("Input")]
		public int Input { get; set;}

		[OutputAttribute("Result")]
		public int Output { get; set;}

		public override void Run ()
		{
			for(int i=0; i<LoopNumber; i++)
			{
				System.Threading.Thread.Sleep (SleepTime);
				Console.WriteLine (i);
			}
			Console.WriteLine ("Finished (from the Method)!");
			Output = Input;
		}

		public override void Setup ()
		{
			throw new NotImplementedException ();
		}
	}
}
