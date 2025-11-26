using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayısalİşlemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            int kare;
            sayi = Convert.ToInt32(textBox1.Text);

            kare = sayi * sayi;

            label3.Text = kare.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi2;
            int kup;

            sayi2 = Convert.ToInt32(textBox2.Text);
            kup = sayi2 * sayi2 * sayi2;

            label5.Text = kup.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            double sayi3, sayi4;
            double us;

            sayi3 = Convert.ToDouble(textBox3.Text);
            sayi4 = Convert.ToDouble(textBox4.Text);
            us = Math.Pow(sayi3, sayi4); //Math.Pow(x, y): x üzeri y (x^y).
            label7.Text = us.ToString();
;           
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi5;
            double karekok;

            sayi5 = Convert.ToDouble(textBox5.Text);

            karekok = Math.Sqrt(sayi5);

            label11.Text = karekok.ToString();
;      }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi6;
            int sayi7;
            int mod;


            sayi6 = Convert.ToInt32(textBox6.Text);
            sayi7 = Convert.ToInt32(textBox7.Text);
            mod = sayi6 % sayi7;

            label15.Text = mod.ToString();
        }
    }
}
