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
    public partial class noktadikdortgen : Form
    {
        nokta n = new nokta();
        dikdortgen d = new dikdortgen();
        public noktadikdortgen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            n.X = int.TryParse(textBox4.Text, out var value) ? value : n.X;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            n.Y = int.TryParse(textBox5.Text, out var value) ? value : n.Y;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            d.Merkez.X = int.TryParse(textBox9.Text, out var value) ? value : d.Merkez.X;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            d.Merkez.Y = int.TryParse(textBox11.Text, out var value) ? value : d.Merkez.Y;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            d.En = int.TryParse(textBox13.Text, out var value) ? value : d.En;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            d.Boy = int.TryParse(textBox15.Text, out var value) ? value : d.Boy;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int solX = d.Merkez.X - d.En / 2;
            int sagX = d.Merkez.X + d.En / 2;
            int altY = d.Merkez.Y - d.Boy / 2;
            int ustY = d.Merkez.Y + d.Boy / 2;

            if ((string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox9.Text) ||
                string.IsNullOrEmpty(textBox11.Text) ||
                string.IsNullOrEmpty(textBox13.Text) ||
                string.IsNullOrEmpty(textBox15.Text)
                ))
            {
                textBox16.Text = "Değer Giriniz!";
            }
            else
            {
                if(n.X >= solX && n.X <= sagX && n.Y >=  altY && n.Y <= ustY){
                    textBox16.Text = "Çarpışma var!";
                }
                else
                {
                    textBox16.Text = "Çarpışma Yok!";

                }
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
