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

namespace ygsPuanHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkce, matematik, sosyal, fen;
            double ygs1, ygs2, ygs3, ygs4, ygs5, ygs6;

            turkce = Convert.ToDouble(textBox1.Text);
            matematik = Convert.ToDouble(textBox2.Text);
            sosyal = Convert.ToDouble(textBox3.Text);
            fen = Convert.ToDouble(textBox4.Text);

            ygs1 = (turkce * 1.99 + sosyal * 1 + matematik * 3.99 + fen * 2.99) + 100.160;
            lblygs1.Text = ygs1.ToString();
            ygs2 = (turkce * 1.99 + sosyal * 1 + matematik * 2.99 + fen * 3.99) + 100.160;
            lblygs2.Text = ygs2.ToString();
            ygs3 = (turkce * 3.99 + sosyal * 2.99 + matematik * 1.99 + fen * 1) + 100.160;
            lblygs3.Text = ygs3.ToString();
            ygs4 = (turkce * 3.99 + sosyal * 3.99 + matematik * 1.99 + fen * 1) + 100.160;
            lblygs4.Text = ygs4.ToString();
            ygs5 = (turkce * 3.69 + sosyal * 1.99 + matematik * 3.29 + fen * 1) + 100.120;
            lblygs5.Text = ygs5.ToString();
            ygs6 = (turkce * 3.29 + sosyal * 1 + matematik * 3.69 + fen * 1.99) + 100.120;
            lblygs6.Text = ygs6.ToString();
        }
    }
}
