namespace doubleAritmetikOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HesaplaButton_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;
            double toplam, fark, carpim, bolum;

            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim= sayi1 * sayi2;
            bolum = sayi1 / sayi2;

            // bu kýsma kadar bilgiler ram de tutuluyordu.þimdi yazdýrmaya baþlicaz

            lblTopla.Text = toplam.ToString(); 
            lblFark.Text = fark.ToString(); 
            lblbol.Text = carpim.ToString(); 
            lblCarp.Text = bolum.ToString(); 

        }

        
    }
}
