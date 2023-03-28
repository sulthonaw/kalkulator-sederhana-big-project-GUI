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

        }
    }
}
