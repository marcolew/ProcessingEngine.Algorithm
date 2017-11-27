using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingEngine.Algorithm
{
	public interface IAlgorithm
	{
		/// <summary>
		/// Method that will be called for training or parameter estimation
		/// </summary>
		void Setup();

		/// <summary>
		/// Method that will be called for running the implemented algorithm
		/// </summary>
		void Run();
	}
}
