using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingEngine.Algorithm
{
	public class NotNecessaryException : Exception
	{
		public NotNecessaryException()
		{
		}

		public NotNecessaryException(string message)
		: base(message)
		{
		}

		public NotNecessaryException(string message, Exception inner)
		: base(message, inner)
		{
		}
	}
}
