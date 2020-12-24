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
    public partial class PowerFunctionForm : Form
    {
        public PowerFunctionForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PFButton_Click(object sender, EventArgs e)
        {
            try
            {
                PowerFunction f = new PowerFunction(double.Parse(a.Text), double.Parse(b.Text), double.Parse(c.Text), double.Parse(d.Text), double.Parse(m.Text), double.Parse(n.Text), double.Parse(k.Text));
                AnswerTextBox.Text = "d(" + f.Function + ") = " + f.Differential();
            }
            catch
            {
                AnswerTextBox.Text = "Значения введены неверно.";
            }
            
        }

        private void PowerFunctionForm_Load(object sender, EventArgs e)
        {

        }

        private void plus1_Click(object sender, EventArgs e)
        {

        }
    }
}
