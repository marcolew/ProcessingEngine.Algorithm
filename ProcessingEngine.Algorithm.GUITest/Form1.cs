using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProcessingEngine.Algorithm.ExampleImplementation;

namespace ProcessingEngine.Algorithm.GUITest
{
    public partial class Form1 : Form
    {
        private ExampleImplementation.ExampleAlgorithm algorithm = new ExampleAlgorithm();

        public Form1()
        {
            InitializeComponent();
            algorithm.ParametersChanged += AlgorithmOnParametersChanged;
        }

        private int numChanges = 0;

        private void AlgorithmOnParametersChanged(object sender, EventArgs eventArgs)
        {
            numChanges++;
            label1.Text = "Parameters changed! " + numChanges.ToString() + " times.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl u = algorithm.GetParameterControl;
            panel1.Controls.Add(u);
        }
    }
}
