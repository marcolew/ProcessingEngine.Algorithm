using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessingEngine.Algorithm
{
	/// <summary>
	/// Abtract Algorithm class for all concrete Implementations in 'Processing Engine for Reliability'
	/// </summary>
	[Serializable]
	public abstract class Algorithm
	{
		/// <summary>
		/// Return List of all parameters in the implemented algorithm
		/// </summary>
		public Dictionary<string, object> Parameters
		{
			get
			{
				var props = from p in this.GetType().GetProperties()
					let attr = p.GetCustomAttributes(typeof(ParameterAttribute), true)
						where attr.Length == 1
					select new { Property = p, Attribute = attr.First() as ParameterAttribute };

				return null;
			}
		}

		/// <summary>
		/// Method that will be called for training or parameter estimation
		/// </summary>
		public abstract void Setup();

		/// <summary>
		/// Method that will be called for running the implemented algorithm
		/// </summary>
		public abstract void Run();

	}
}
