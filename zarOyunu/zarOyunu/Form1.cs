using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
            Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            
            int sayi1 = rastgele.Next(1, 7); 
            int sayi2 = rastgele.Next(1, 7);
            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
        }

       
    }
}
