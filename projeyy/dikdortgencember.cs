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
    public partial class dikdortgencember : Form
    {
        cember c = new cember();
        dikdortgen d = new dikdortgen();
        public dikdortgencember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            d.Merkez.X = int.TryParse(textBox13.Text, out var value) ? value : d.Merkez.X;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            d.Merkez.Y = int.TryParse(textBox1.Text, out var value) ? value : d.Merkez.Y;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            d.En = int.TryParse(textBox3.Text, out var value) ? value : d.En;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            d.Boy = int.TryParse(textBox2.Text, out var value) ? value : d.Boy;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            c.Merkez.X = int.TryParse(textBox10.Text, out var value) ? value : c.Merkez.X;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            c.Merkez.Y = int.TryParse(textBox12.Text, out var value) ? value : c.Merkez.Y;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            c.Yaricap = int.TryParse(textBox16.Text, out var value) ? value : c.Yaricap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x1 = d.Merkez.X - d.En / 2;
            int y1 = d.Merkez.Y - d.Boy / 2;
            int x2 = d.Merkez.X + d.En / 2;
            int y2 = d.Merkez.Y + d.Boy / 2;
            double distance = Math.Sqrt(Math.Pow(c.Merkez.X-d.Merkez.X,2) + Math.Pow(c.Merkez.Y-d.Merkez.Y,2));

            int dx = Math.Abs(c.Merkez.X - d.Merkez.X);
            int dy = Math.Abs(c.Merkez.Y - d.Merkez.Y);

            if ((string.IsNullOrEmpty(textBox13.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox10.Text) ||
                string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox12.Text) ||
                string.IsNullOrEmpty(textBox16.Text)
                ))
            {
                textBox21.Text = "Değer Giriniz!";
            }
            else
            {
                if (distance <= c.Yaricap || c.Merkez.X + c.Yaricap >= x1 && c.Merkez.X - c.Yaricap <= x2 && c.Merkez.Y + c.Yaricap >= y1 
                    && c.Merkez.Y - c.Yaricap <= y2)
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
    }
}
