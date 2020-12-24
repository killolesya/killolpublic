using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifferentialWithForms
{
    public partial class TrigonometricFunctionForm : Form
    {
        public TrigonometricFunctionForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            TrigonometricFunction f = new TrigonometricFunction();
            switch (TFComboBox.SelectedIndex)
            {
                case 0: f = new TrigonometricFunction(1); break;
                case 1: f = new TrigonometricFunction(2); break;
                case 2: f = new TrigonometricFunction(3); break;
                case 3: f = new TrigonometricFunction(4); break;
            }
            TFtextBox.Text = "d(" + f.Function + ") = " + f.Differential();
        }
    }
}
