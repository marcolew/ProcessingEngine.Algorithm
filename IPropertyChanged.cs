using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingEngine.Algorithm
{
	public interface IPropertyChanged
	{
		event EventHandler ParametersChanged;
		void OnParametersChanged(EventArgs e);
	}
}
