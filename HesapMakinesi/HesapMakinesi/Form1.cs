using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            toplam = sayi1 + sayi2;

            label4.Text = toplam.ToString();



            ;

            


            
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int birinciSayi;
            int ikinciSayi;
            int carpim;

            birinciSayi = Convert.ToInt32(textBox3.Text);
            ikinciSayi = Convert.ToInt32(textBox4.Text);
            carpim = birinciSayi * ikinciSayi;
            label8.Text = carpim.ToString();
        }
    }
}
