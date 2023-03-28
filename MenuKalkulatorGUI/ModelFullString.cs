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
    public partial class ModelFullString : Form
    {
        public ModelFullString()
        {
            InitializeComponent();
        }

        private void ModelFullString_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "tujuh";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += " dikurangi ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += " dikali ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += " dibagi ";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            var htng = new HitungTerbilang();
            string result = htng.hitung(textBox1.Text);
            textBox1.Text = result + " ";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "nol";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "sembilan";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "delapan";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ditambah ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "enam";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "lima";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "empat";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "tiga";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "dua";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "satu";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }

    public class HitungTerbilang
    {
        public static string[] _dataAngkaString = { "nol", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas", "belas", "puluh" };

        public static string[] _dataOperanString = { "ditambah", "+", "dikurangi", "-", "dikali", "*", "dibagi", "/" };

        public string hitung(string input)
        {
            Console.Write("Input kata : ");

            string[] inputArr = input.Split(' ');

            int pertama = 0, kedua = 0;
            char operan = ' ';

            for (int i = 0; i < _dataAngkaString.Length; i++)
            {
                if (inputArr[0] == _dataAngkaString[i])
                {
                    pertama = i;
                    break;
                }
            }

            for (int i = 0; i < _dataOperanString.Length; i++)
            {
                if (inputArr[1] == _dataOperanString[i]) { operan = Convert.ToChar(_dataOperanString[i + 1]); break; }
            }

            for (int i = 0; i < _dataAngkaString.Length; i++)
            {
                if (inputArr[2] == _dataAngkaString[i])
                {
                    kedua = i;
                    break;
                };
            }

            return perhitungan(pertama, operan, kedua);
        }

        public static string perhitungan(int pertama, char operan, int kedua)
        {
            int hasil = 0;

            switch (operan)
            {
                case '+':
                    hasil = pertama + kedua;
                    break;
                case '-':
                    hasil = pertama - kedua;
                    break;
                case '*':
                    hasil = pertama * kedua;
                    break;
                case '/':
                    hasil = pertama / kedua;
                    break;
            }

            if (hasil >= 0 && hasil < 12)
            {
                return ($"Hasil : {_dataAngkaString[hasil]}");
            }
            else if (hasil >= 12 && hasil < 20)
            {
                hasil -= 10;
                return ($"Hasil : {_dataAngkaString[hasil]} {_dataAngkaString[12]}");
            }
            else if (hasil < 0)
            {
                if (hasil < -12)
                {
                    hasil *= -1;
                    return ($"Hasil : negatif {_dataAngkaString[hasil]} {_dataAngkaString[12]}");
                }
                else
                {
                    hasil *= -1;
                    return ($"Hasil : negatif {_dataAngkaString[hasil]}");
                }
            }
            else
            {
                return ($"Hasil : {hasil}");
            }
        }

    }


}

