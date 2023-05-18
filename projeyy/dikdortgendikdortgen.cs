using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** PROGRAMLAMAYA GİRİŞİ DERSİ
**
** ÖDEV NUMARASI: 01
** ÖĞRENCİ ADI: Yalkın Can Yalınız
** ÖĞRENCİ NUMARASI.: B221210101
** DERS GRUBU: A
YOUTUBE LİNKİ… …:  https://youtu.be/0XHFBK_i0CY
****************************************************************************/
namespace projeyy
{
    public partial class dikdortgendikdortgen : Form
    {
        dikdortgen d1 = new dikdortgen();
        dikdortgen d2 = new dikdortgen();
        public dikdortgendikdortgen()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            d1.Merkez.X = int.TryParse(textBox13.Text, out var value) ? value : d1.Merkez.X;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            d1.Merkez.Y = int.TryParse(textBox16.Text, out var value) ? value : d1.Merkez.Y;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            d1.En = int.TryParse(textBox18.Text, out var value) ? value : d1.En;
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            d1.Boy = int.TryParse(textBox20.Text, out var value) ? value : d1.Boy;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            d2.Merkez.X = int.TryParse(textBox9.Text, out var value) ? value : d2.Merkez.X;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            d2.Merkez.Y = int.TryParse(textBox11.Text, out var value) ? value : d2.Merkez.Y;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            d2.En = int.TryParse(textBox3.Text, out var value) ? value : d2.En;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            d2.Boy = int.TryParse(textBox4.Text, out var value) ? value : d2.Boy;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x1 = d1.Merkez.X - d1.En / 2;
            int y1 = d1.Merkez.Y - d1.Boy / 2;
            int x2 = d2.Merkez.X - d2.En / 2;
            int y2 = d2.Merkez.Y - d2.Boy / 2;

            int xMesafe = Math.Abs(d1.Merkez.X - d2.Merkez.X);
            int yMesafe = Math.Abs(d1.Merkez.Y - d2.Merkez.Y);
            int enToplam = d1.En + d2.En;
            int boyToplam = d1.Boy + d2.Boy;

            if ((string.IsNullOrEmpty(textBox13.Text) ||
                string.IsNullOrEmpty(textBox16.Text) ||
                string.IsNullOrEmpty(textBox18.Text) ||
                string.IsNullOrEmpty(textBox20.Text) ||
                string.IsNullOrEmpty(textBox9.Text) ||
                string.IsNullOrEmpty(textBox11.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text)
                ))
            {
                textBox21.Text = "Değer Giriniz!";
            }
            else
            {
                if (xMesafe <= enToplam / 2 && yMesafe <= boyToplam / 2)
                {
                    textBox21.Text = "Çarpışma var!";
                }
                else
                {
                    textBox21.Text = "Çarpışma yok!";
                }
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
