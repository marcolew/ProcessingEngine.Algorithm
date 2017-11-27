using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingEngine.Algorithm
{
	public class AlgorithmInfo
	{
		private object _algorithm;
		public AlgorithmInfo(object algorithm)
		{
			if (algorithm is IAlgorithm)
			{
				_algorithm = algorithm;
			}
			else
				throw new FormatException("Algorithm Info cannot be initiated, because the Interface IAlgorithm is not implemented.");
		}


		/// <summary>
		/// Return List of all parameters in the implemented algorithm
		/// </summary>
		public IEnumerable<PropertyInfo> GetParameterProperties()
		{
			var props = from p in _algorithm.GetType().GetProperties()
						let attr = p.GetCustomAttributes(typeof(ParameterAttribute), true)
						where attr.Length == 1
						select p;

			return props;
		}

		/// <summary>
		/// Return List of all input properties in the implemented algorithm
		/// </summary>
		public IEnumerable<PropertyInfo> GetInputProperties()
		{
			var props = from p in _algorithm.GetType().GetProperties()
						let attr = p.GetCustomAttributes(typeof(InputAttribute), true)
						where attr.Length == 1
						select p;

			return props;

		}

		/// <summary>
		/// Return List of all output properties in the implemented algorithm
		/// </summary>
		public IEnumerable<PropertyInfo> GetOutputProperties()
		{

			var props = from p in _algorithm.GetType().GetProperties()
						let attr = p.GetCustomAttributes(typeof(OutputAttribute), true)
						where attr.Length == 1
						select p;

			return props;

		}
	}
}
