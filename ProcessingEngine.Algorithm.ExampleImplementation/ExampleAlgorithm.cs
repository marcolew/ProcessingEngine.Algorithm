using System;
using System.Windows.Forms;

namespace ProcessingEngine.Algorithm.ExampleImplementation
{
	[Serializable]
	public class ExampleAlgorithm: Algorithm
	{
	    public ExampleAlgorithm()
	    {
            pControl.txtLoop.TextChanged += TxtLoopOnTextChanged;
	        pControl.txtSleep.TextChanged += TxtSleepOnTextChanged;
	    }

	    private void TxtSleepOnTextChanged(object sender, EventArgs eventArgs)
	    {
	        SleepTime = Convert.ToInt32(pControl.txtSleep.Text);
            OnParametersChanged(null);
        }

	    private void TxtLoopOnTextChanged(object sender, EventArgs eventArgs)
	    {
            LoopNumber = Convert.ToInt32(pControl.txtLoop.Text);
            OnParametersChanged(null);
        }

	    private UserControl1 pControl = new UserControl1();

	    [ParameterAttribute("Number of Loops")]
	    public int LoopNumber { get; set; }

        [ParameterAttribute("Milliseconds to Sleep")]
		public int SleepTime { get; set;}

		[InputAttribute("Input")]
		public int Input { get; set;}

		[OutputAttribute("Result")]
		public int Output { get; set;}

        public override UserControl GetParameterControl
        {
            get { return pControl; }
        }

        public override void Run ()
		{
			for(int i=0; i<LoopNumber; i++)
			{
				System.Threading.Thread.Sleep (SleepTime);
				Console.WriteLine (i);
			}
			Console.WriteLine ("Finished (from the Method)!");
			Output = Input;
		}

		public override void Setup ()
		{
			throw new NotImplementedException ();
		}

	    protected override void OnParametersChanged(EventArgs e)
	    {
	        base.OnParametersChanged(e);
	    }
	}
}
