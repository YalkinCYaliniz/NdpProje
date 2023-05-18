using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
    public partial class noktacember : Form
    {
        cember c = new cember();
        nokta n = new nokta();
        public noktacember()
        {
            InitializeComponent();
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
            c.Merkez.X = int.TryParse(textBox9.Text, out var value) ? value : c.Merkez.X;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            c.Merkez.Y = int.TryParse(textBox11.Text, out var value) ? value : c.Merkez.Y;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            c.Yaricap = int.TryParse(textBox13.Text, out var value) ? value : c.Yaricap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double uzaklik = Math.Sqrt(Math.Pow(c.Merkez.X - n.X, 2) + Math.Pow(c.Merkez.Y - n.Y, 2));
            if ((string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox9.Text) ||
                string.IsNullOrEmpty(textBox11.Text) ||
                string.IsNullOrEmpty(textBox13.Text)
                ))
            {
                textBox16.Text = "Değer Giriniz!";
            }
            else
            {
                if (uzaklik <= c.Yaricap)
                {
                    textBox16.Text = "Çarpışma Var!";
                }
                else
                {
                    textBox16.Text = "Çarpışma yok!";
                }
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
