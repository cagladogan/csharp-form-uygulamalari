using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayac
{
    public partial class Form1 : Form
    {
        private int sayi = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi = sayi + 1;

            label1.Text = sayi.ToString();

            if (sayi >= 20)
            {
                sayi = 0; 
            }
        }
    }
}
