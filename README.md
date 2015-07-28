# ProcessingEngine.Algorithm
Interface and Helper Functions to implement Maschine Learning Algorithms for an automated time-based processing.
## Puropose
The Libary provides an abstract class called "algorithm". By inheriting from this class it is possible to build algorithms which can be processed in a so called processing engine triggered by events (e.g. at a certain time). This gets easily possible because Algorithms derived from the abstract algorithm class implement a particular interface which can be accessed by the engine.

The interface provides

- A method "Train" which is used to prepare algorithms in terms of training, parameter estimation, etc.
- A method "Run" which is used to process data and write results to an output

In addition Attributes are available which characterize properties as

- Input (e.g. a timesseries)
- Output (e.g. a single number such as the mean of the provided input series)
- Parameter (e.g. a configuration parameter for a particular algorithm

## Example

A basic implementation example is provided within the code and can be executed from the Testconsole-Project.

```
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
			Console.WriteLine ("Finished (Message from the Method)!");
			Output = Input;
		}

		public override void Setup ()
		{
			throw new NotImplementedException ();
		}
	}
}
```
The implementation has two parameters which are used in this example to create a loop which simulates idle time in case of running "Run". We have one input property and one output property while within the run method the input property is directly assigned to the output. All properties are charaterized via a name (e.g. Result for the OutputAttribute) The method "Setup" is not implemented in this example case.
