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
    public partial class ModelMenu : Form
    {
        public ModelMenu()
        {
            InitializeComponent();
        }

        private void ModelMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonPenjumlahan_CheckedChanged(object sender, EventArgs e)
        {
            inputOperator.Text = "+";
        }

        private void buttonPengurangan_CheckedChanged(object sender, EventArgs e)
        {
            inputOperator.Text = "-";
        }

        private void buttonPerkalian_CheckedChanged(object sender, EventArgs e)
        {
            inputOperator.Text = "*";
        }

        private void buttonPembagian_CheckedChanged(object sender, EventArgs e)
        {
            inputOperator.Text = "/";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string hasil = $"{input1.Text}{inputOperator.Text}{input2.Text}";
            outputHasil.Text = new DataTable().Compute(hasil, null).ToString();
        }

        private void input1_TextChanged(object sender, EventArgs e)
        { 
            if (input1.Text.Length > 0 && input2.Text.Length > 0 && inputOperator.Text.Length > 0) buttonEquals.Enabled = true;
            else buttonEquals.Enabled = false;
        }

        private void input2_Click(object sender, EventArgs e)
        {
            input2.Focus();
        }

        private void input1_Click(object sender, EventArgs e)
        {
            input1.Focus();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            input1.Text = "";
            input2.Text = "";
            outputHasil.Text = "";

            Panel menuOptions = this.Controls.Find("panel2", true).FirstOrDefault() as Panel;

            foreach (Control ctrl in menuOptions.Controls)
            {
                if (ctrl is RadioButton) ((RadioButton)ctrl).Checked = false;
            }
        }
    }
}
