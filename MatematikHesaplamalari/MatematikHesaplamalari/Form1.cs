using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikHesaplamalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birKenar;
            int alan, cevre;

            birKenar = Convert.ToInt32(textBox1.Text);
            alan = birKenar * birKenar;
            cevre = birKenar * 4;

            label14.Text = alan.ToString();
            label15.Text = cevre.ToString();



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            textBox2.Visible = false;
            label2.Text = "KARE";
            label2.Visible= true;  
            panel1.Visible =true;
            panel2.Visible =true;
            panel3.Visible =false;

        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Kısa Kenarı Girin ";
            label2.Visible = true;
            panel1.Visible = true;
            label2.Text = "DIKDORTGEN";
            label7.Visible = true;
            textBox2.Visible = true;
            panel2.Visible = false;
            panel3.Visible = true;
            
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kisa, uzun;
            int alann, cevree;

            kisa = Convert.ToInt32(textBox1.Text);
            uzun = Convert.ToInt32(textBox2.Text);

            alann = kisa * uzun;
            cevree = (2 * kisa) + (2 * uzun);

            label10.Text = alann.ToString();
            label8.Text = cevree.ToString();

        }

      
    }
}
