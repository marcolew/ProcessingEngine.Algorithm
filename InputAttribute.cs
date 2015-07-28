using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessingEngine.Algorithm
{
	[AttributeUsage(AttributeTargets.Property)]
	public class InputAttribute : Attribute
	{
		public InputAttribute(string name)
		{
			Name = name;
		}

		protected InputAttribute()
		{

		}

		public string Name;
	}

}