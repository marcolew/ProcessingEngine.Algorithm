using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

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
		public IEnumerable<PropertyInfo> ParameterProperties
		{
			get
			{
				var props = from p in this.GetType ().GetProperties ()
				            let attr = p.GetCustomAttributes (typeof(ParameterAttribute), true)
				            where attr.Length == 1
				            select p; 

				return props;
			}
		}

		/// <summary>
		/// Return List of all input properties in the implemented algorithm
		/// </summary>
		public IEnumerable<PropertyInfo> InputProperties
		{
			get
			{
				var props = from p in this.GetType ().GetProperties ()
				            let attr = p.GetCustomAttributes (typeof(InputAttribute), true)
				            where attr.Length == 1
				            select p; 

				return props;
			}
		}

		/// <summary>
		/// Return List of all output properties in the implemented algorithm
		/// </summary>
		public IEnumerable<PropertyInfo> OutputProperties
		{
			get
			{
				var props = from p in this.GetType ().GetProperties ()
					let attr = p.GetCustomAttributes (typeof(OutputAttribute), true)
						where attr.Length == 1
					select p; 

				return props;
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

        /// <summary>
        /// Porperty with the User Control which is used to define the parameters of the algorithm
        /// </summary>
	    public abstract System.Windows.Forms.UserControl GetParameterControl { get; }

        /// <summary>
        /// Eventhandler that can be invoked, if Parameters changed.
        /// </summary>
	    public event EventHandler ParametersChanged;

        /// <summary>
        /// The event-invoking method that derived classes can override.
        /// </summary>
        /// <param name="e">EventArgs</param>
        protected virtual void OnParametersChanged(EventArgs e)
        {
            ParametersChanged?.Invoke(this, e);
        }


    }
}
