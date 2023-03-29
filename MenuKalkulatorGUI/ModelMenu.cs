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

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           //
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void buttonEquals2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

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
        }
    }
}
