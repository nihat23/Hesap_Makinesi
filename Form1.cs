using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace double_hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi1, sayi2, sonuc;
                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);

                sonuc = sayi1 + sayi2;
                textBox3.Text = sonuc.ToString();
            }
            catch (Exception)
            {

                label4durum.Text = "Boş Bırakmayın..!";
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi1, sayi2, sonuc;
                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);

                sonuc = sayi1 - sayi2;
                textBox3.Text = sonuc.ToString();
            }
            catch (Exception)
            {
                label4durum.Text = "Boş Bırakmayın..!"; 
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi1, sayi2, sonuc;
                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);

                sonuc = sayi1 * sayi2;
                textBox3.Text = sonuc.ToString();
            }
            catch (Exception)
            {

                label4durum.Text = "Boş Bırakmayın..!";
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi1, sayi2, sonuc;
                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);

                sonuc = sayi1 / sayi2;
                textBox3.Text = sonuc.ToString();
            }
            catch (Exception)
            {

                label4durum.Text = "Boş Bırakmayın..!";
            } 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/n.beyi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog renk = new ColorDialog();
            if (renk.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = renk.Color;
                button1.BackColor = renk.Color;
                button2.BackColor = renk.Color;
                button3.BackColor = renk.Color;
                button4.BackColor = renk.Color;
                button5.BackColor = renk.Color;
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            label4durum.Text = "__";
        }
              
    }
}
