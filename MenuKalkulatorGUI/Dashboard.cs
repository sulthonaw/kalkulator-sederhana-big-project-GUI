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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void buttonModelMenu_Click(object sender, EventArgs e)
        {
            new ModelMenu().Show();
        }

        private void buttonModelStringDanSimbol_Click(object sender, EventArgs e)
        {
            new ModelStringDanSimbol().Show();
        }

        private void buttonModelFullString_Click(object sender, EventArgs e)
        {
            new ModelFullString().Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonModelSimbol_Click(object sender, EventArgs e)
        {
            new ModelSimbol().Show();
        }
    }
}
