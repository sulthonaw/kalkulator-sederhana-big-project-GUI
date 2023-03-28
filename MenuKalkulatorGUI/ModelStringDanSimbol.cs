using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MenuKalkulatorGUI
{
    public partial class ModelStringDanSimbol : Form
    {
        public ModelStringDanSimbol()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void ModelStringDanSimbol_Load(object sender, EventArgs e)
        {

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBox.Text += "-";
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            textBox.Text += "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBox.Text += "/";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox.Text += ".";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string value = new DataTable().Compute(textBox.Text, null).ToString();
            textBox.Text = value;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox.Text += "+";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
        }
    }
}
