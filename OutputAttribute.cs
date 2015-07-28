using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessingEngine.Algorithm
{
	[AttributeUsage(AttributeTargets.Property)]
	public class OutputAttribute : Attribute
	{
		public OutputAttribute(string name)
		{
			Name = name;
		}

		protected OutputAttribute()
		{

		}

		public string Name;
	}

}
