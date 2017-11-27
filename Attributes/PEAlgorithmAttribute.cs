using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessingEngine.Algorithm
{
	[AttributeUsage(AttributeTargets.Class)]
	public class PEAlgorithmAttribute : Attribute
	{
		public PEAlgorithmAttribute(string name)
		{
			Name = name;
		}

        public PEAlgorithmAttribute(string name, string description)
        {
            Name = name;
            Description = description;
        }

        protected PEAlgorithmAttribute()
		{

		}

		public string Name;

        public string Description;

	}

}