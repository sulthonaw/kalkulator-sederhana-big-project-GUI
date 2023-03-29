using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuKalkulatorGUI
{
    public partial class ModelSimbol : Form
    {
        public ModelSimbol()
        {
            InitializeComponent();
        }

        private void ModelSimbol_Load(object sender, EventArgs e)
        {

        }

        private void outputHasil_TextChanged(object sender, EventArgs e)
        {
            if (input1.Text.Length > 0 && input2.Text.Length > 0 && simbol.Text.Length > 0) buttonEquals.Enabled = true;
            else buttonEquals.Enabled = false;
        }

        private void input1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
          
            string hasil = $"{input1.Text}{simbol.SelectedItem}{input2.Text}";
            outputHasil.Text = new DataTable().Compute(hasil, null).ToString();
        }

        private void simbol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
