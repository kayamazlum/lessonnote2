using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekrar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // [1] Vize final ortalama hesaplama 
        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final;
            vize = Convert.ToUInt16(textBox1.Text);
            final = Convert.ToInt16(textBox2.Text);
            double ortalama = (vize * 0.4) + (final * 0.6);
            
            if(ortalama>=90 && ortalama <= 100)
            {
                label4.Text = "AA";
            }
            else if (ortalama >= 80 && ortalama < 90)
            {
                label4.Text = "BA";
            }
            else if (ortalama >= 70 && ortalama < 80)
            {
                label4.Text = "CA";
            }
            else if (ortalama >= 60 && ortalama < 70)
            {
                label4.Text = "CC";
            }
            else if (ortalama >= 50 && ortalama < 60)
            {
                label4.Text = "DD";
            }
            else
            {
                label4.Text = "FF";
            }
        }

        // [2] Hangi günde olduğumuzu bulma 
        private void button2_Click(object sender, EventArgs e)
        {
            int gun = Convert.ToInt16(DateTime.Now.DayOfWeek);

            switch (gun)
            {
                case 1: MessageBox.Show("Pazartesi");
                    break;
                case 2: MessageBox.Show("Salı");
                    break;
                case 3:
                    MessageBox.Show("Çarşamba");
                    break;
                case 4:
                    MessageBox.Show("Perşembe");
                    break;
                default: MessageBox.Show("Hatalı giriş");
                    break;
            }
        }

        // [3] Seçilen butona göre işlem yapma 
        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt16(textBox3.Text);
            int sayi2 = Convert.ToInt16(textBox4.Text);
            if(radioButton1.Checked == true)
            {
                label9.Text = (sayi1 + sayi2).ToString();
            }
            else
            {
                label9.Text = (sayi1 * sayi2).ToString();
            }
        }

        // [4] Kullanıcı adı, şifre girişi 
        private void button4_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox5.Text;
            string sifre = textBox6.Text;

            if (kullaniciAdi == "admin" && sifre == "123456")
                MessageBox.Show("Giriş başarılı");
            else
                MessageBox.Show("Giriş başarısız");
        }

        // [5] Girilen değerlerin ve aralarındaki değerlerin toplamı
        private void button5_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt16(textBox7.Text);
            int bitis = Convert.ToInt16(textBox8.Text);
            int toplam = 0;
            for(int i = baslangic ; i<= bitis ; i++)
            {
                toplam += i;
            }
            MessageBox.Show("Toplamları : "+toplam);
        }

        // [6] Girilen metnin girilen değer kadar yazılması
        private void button6_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox9.Text);
            String metin = textBox10.Text;

            for(int i=0; i < sayi ; i++)
            {
                listBox1.Items.Add(i+". "+metin);
            }
        }
    }
}
