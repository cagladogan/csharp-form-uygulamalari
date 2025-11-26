using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denklem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sınav1, sınav2, ortalama;

            sınav1 = Convert.ToInt32(textBox2.Text);
            sınav2 = Convert.ToInt32(textBox3.Text);

            ortalama = (sınav1 + sınav2) / 2;
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(ortalama);

            if(ortalama >= 50)
            {
                listBox5.Items.Add("geçti");
            }else
            {
                listBox5.Items.Add("kaldı");

            }
        }
    }
}
