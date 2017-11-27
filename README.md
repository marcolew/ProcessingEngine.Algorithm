# ProcessingEngine.Algorithm
Interface and Helper Functions to implement Maschine Learning Algorithms for an automated time-based processing.
## Puropose
The Libary provides an abstract class called "algorithm". By inheriting from this class it is possible to build algorithms which can be processed in a so called processing engine triggered by events (e.g. at a certain time). This gets easily possible because Algorithms derived from the abstract algorithm class implement a particular interface which can be accessed by the engine.

The interface provides

- A method "Setup" which is used to prepare algorithms in terms of training, parameter estimation, etc.
- A method "Run" which is used to process data and write results to an output

In addition Attributes are available which characterize properties as

- Input (e.g. a timesseries)
- Output (e.g. a single number such as the mean of the provided input series)
- Parameter (e.g. a configuration parameter for a particular algorithm

## Example

A basic implementation example is provided within the code and can be executed with the unit test projet.

```
namespace ProcessingEngine.Algorithm.Sample
{
	[PEAlgorithm("Sample")]
	[Serializable]
	public class SampleAlgorithm:IAlgorithm
	{
		[Parameter("Faktor")]
		public int Parameter { get; set; }

		[Input("Input")]
		public int Input { get; set; }

		[Output("Output")]
		public int Output { get; set; }

		public void Run()
		{
			Output = Input * Parameter; 
		}

		public void Setup()
		{
			throw new NotNecessaryException("This Algorithm doesn't need a Setup!");
		}
	}
}
```
The implementation has one parameter which is used as a factor multyplied with the input by running "Run". We have one input property and one output property while within the run method the input property is multyplied with the factor and then assigned to the output. All properties are charaterized via a name (e.g. Result for the OutputAttribute). The method "Setup" is not implemented in this example case.
