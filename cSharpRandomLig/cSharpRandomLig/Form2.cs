using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpRandomLig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Random golSayisi = new Random();
        int bjkpuan = 0;
        int fbpuan = 0;
        int gspuan = 0;
        int tspuan = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = golSayisi.Next(0, 7);
            int b = golSayisi.Next(0, 7);
            int c = golSayisi.Next(0, 7);
            int d = golSayisi.Next(0, 7);

            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label6.Text = c.ToString();
            label8.Text = d.ToString();


            if(Convert.ToInt32 (label4.Text)> Convert.ToInt32(label5.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();

            }
            if (Convert.ToInt32(label4.Text) < Convert.ToInt32(label5.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label5.Text))
            {
                bjkpuan = bjkpuan + 1;
                fbpuan = fbpuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();


            }

            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label8.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();

            }
            if (Convert.ToInt32(label6.Text) < Convert.ToInt32(label8.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) == Convert.ToInt32(label8.Text))
            {
                tspuan = tspuan + 1;
                gspuan = gspuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labeltspuan.Text = tspuan.ToString();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int a = golSayisi.Next(0, 7);
            int b = golSayisi.Next(0, 7);
            int c = golSayisi.Next(0, 7);
            int d = golSayisi.Next(0, 7);

            label15.Text = a.ToString();
            label24.Text = b.ToString();
            label11.Text = c.ToString();
            label21.Text = d.ToString();

            if (Convert.ToInt32(label15.Text) > Convert.ToInt32(label24.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();

            }
            if (Convert.ToInt32(label15.Text) < Convert.ToInt32(label24.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label24.Text) == Convert.ToInt32(label15.Text))
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();


            }

            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label21.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();

            }
            if (Convert.ToInt32(label11.Text) < Convert.ToInt32(label21.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) == Convert.ToInt32(label21.Text))
            {
                tspuan = tspuan + 1;
                bjkpuan = bjkpuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            int a = golSayisi.Next(0, 7);
            int b = golSayisi.Next(0, 7);
            int c = golSayisi.Next(0, 7);
            int d = golSayisi.Next(0, 7);

            label29.Text = a.ToString();
            label34.Text = b.ToString();
            label27.Text = c.ToString();
            label31.Text = d.ToString();

            if (Convert.ToInt32(label29.Text) > Convert.ToInt32(label34.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();

            }
            if (Convert.ToInt32(label29.Text) < Convert.ToInt32(label34.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label29.Text) == Convert.ToInt32(label34.Text))
            {
                tspuan = tspuan + 1;
                fbpuan = fbpuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();


            }

            if (Convert.ToInt32(label27.Text) > Convert.ToInt32(label31.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label27.Text) < Convert.ToInt32(label31.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label27.Text) == Convert.ToInt32(label31.Text))
            {
                gspuan = gspuan + 1;
                bjkpuan = bjkpuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(labelgspuan.Text)> Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelgspuan.Text)> Convert.ToInt32(labeltspuan.Text)&& Convert.ToInt32(labelgspuan.Text)> Convert.ToInt32(labelbjkpuan.Text))
            {

                label37.Text = "ŞAMPİYON GALATASARAY";
                label37.Visible = true;
            }
            if (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelgspuan.Text))
            {
                label37.Text = "ŞAMPİYON BEŞİKTAŞ";
                label37.Visible = true;
            }
            if (Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                label37.Text = "ŞAMPİYON TRABZONSPOR";
                label37.Visible = true;
            }
            if (Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                label37.Text = "ŞAMPİYON FENERBAHÇE";
                label37.Visible = true;
            }
            
                int gsPuan = Convert.ToInt32(labelgspuan.Text);
                int fbPuan = Convert.ToInt32(labelfbpuan.Text);
                int tsPuan = Convert.ToInt32(labeltspuan.Text);
                int bjkPuan = Convert.ToInt32(labelbjkpuan.Text);

                if (gsPuan > fbPuan && gsPuan > tsPuan && gsPuan > bjkPuan)
                {
                    label37.Text = "ŞAMPİYON GALATASARAY";
                }
                else if (bjkPuan > fbPuan && bjkPuan > tsPuan && bjkPuan > gsPuan)
                {
                    label37.Text = "ŞAMPİYON BEŞİKTAŞ";
                }
                else if (tsPuan > fbPuan && tsPuan > gsPuan && tsPuan > bjkPuan)
                {
                    label37.Text = "ŞAMPİYON TRABZONSPOR";
                }
                else if (fbPuan > tsPuan && fbPuan > gsPuan && fbPuan > bjkPuan)
                {
                    label37.Text = "ŞAMPİYON FENERBAHÇE";
                }
                else
                {
                  
                    bool esitlik = (gsPuan == fbPuan) || (gsPuan == tsPuan) || (gsPuan == bjkPuan) ||
                                   (fbPuan == tsPuan) || (fbPuan == bjkPuan) || (tsPuan == bjkPuan);
                    if (esitlik)
                    {
                        label37.Text = "BU SENE ŞAMPİYON YOK. +" +
                        "KARDEŞLİK KAZANDI!!";
                    }
                    else
                    {
                        
                        label37.Text = "ŞAMPİYON BELİRTİLMEMİŞ";
                    }
                }
                label37.Visible = true;
            }





        }


    }

    

