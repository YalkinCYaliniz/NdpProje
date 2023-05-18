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
    public partial class cembercember : Form
    {
        cember c1 = new cember();
        cember c2 = new cember();
        public cembercember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            c1.Merkez.X = int.TryParse(textBox9.Text, out var value) ? value : c1.Merkez.X;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            c1.Merkez.Y = int.TryParse(textBox1.Text, out var value) ? value : c1.Merkez.Y;

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            c1.Yaricap = int.TryParse(textBox13.Text, out var value) ? value : c1.Yaricap;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            c2.Yaricap = int.TryParse(textBox17.Text, out var value) ? value : c2.Yaricap;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            c2.Merkez.X = int.TryParse(textBox5.Text, out var value) ? value : c2.Merkez.X;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            c2.Merkez.Y = int.TryParse(textBox14.Text, out var value) ? value : c2.Merkez.Y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float Ma = Math.Abs(c1.Merkez.X - c2.Merkez.X);
            float Mb = Math.Abs(c1.Merkez.Y - c2.Merkez.Y);
            double Ab = Math.Sqrt(Math.Pow(Ma, 2) + Math.Pow(Mb, 2));
            if ((string.IsNullOrEmpty(textBox9.Text) ||
                string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox9.Text) ||
                string.IsNullOrEmpty(textBox17.Text) ||
                string.IsNullOrEmpty(textBox13.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox14.Text)
                ))
            {
                textBox16.Text = "Değer Giriniz!";
            }
            else
            {
                if (Ab <= c1.Yaricap + c2.Yaricap)
                {
                    textBox16.Text = "Çarpışma Var!";
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
