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
    public partial class FunctionSelectionForm : Form
    {
        public FunctionSelectionForm()
        {
            InitializeComponent();
        }

        private void FunctionSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FunctionSelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void FunctionSelectionButton_Click(object sender, EventArgs e)
        {
            if (FunctionSelectionComboBox.SelectedItem.ToString() == "Степенная")
            {
                PowerFunctionForm newForm = new PowerFunctionForm();
                newForm.Show();
            }
            else if (FunctionSelectionComboBox.SelectedItem.ToString()== "Тригонометрическая")
            {
                TrigonometricFunctionForm newForm = new TrigonometricFunctionForm();
                newForm.Show();
            }
        }
    }
}
