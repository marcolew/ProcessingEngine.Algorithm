using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessingEngine.Algorithm
{
	[AttributeUsage(AttributeTargets.Property)]
	public class ParameterAttribute : Attribute
	{
		public ParameterAttribute(string name)
		{
			Name = name;
		}

		protected ParameterAttribute()
		{

		}

		public string Name;
	}
}
