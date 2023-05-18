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
    public partial class kurekure : Form
    {
        kure k1 = new kure();
        kure k2 = new kure();
        public kurekure()
        {
            InitializeComponent();
        }

        private void kurekure_Load(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            k1.M.X = int.TryParse(textBox11.Text, out var value) ? value : k1.M.X;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            k1.M.Y = int.TryParse(textBox1.Text, out var value) ? value : k1.M.Y;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            k1.M.Z = int.TryParse(textBox2.Text, out var value) ? value : k1.M.Z;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            k1.Yaricap = int.TryParse(textBox3.Text, out var value) ? value : k1.Yaricap;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            k2.Yaricap = int.TryParse(textBox4.Text, out var value) ? value : k2.Yaricap;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            k2.M.X = int.TryParse(textBox16.Text, out var value) ? value : k2.M.X;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            k2.M.Y = int.TryParse(textBox13.Text, out var value) ? value : k2.M.Y;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            k2.M.Z = int.TryParse(textBox6.Text, out var value) ? value : k2.M.Z;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float d = (float)Math.Sqrt(Math.Pow((k1.M.X - k2.M.X), 2) + Math.Pow((k1.M.Y - k2.M.Y), 2) + Math.Pow((k1.M.Z - k2.M.Z), 2));
            if ((string.IsNullOrEmpty(textBox6.Text) ||
                string.IsNullOrEmpty(textBox13.Text) ||
                string.IsNullOrEmpty(textBox16.Text) ||
                string.IsNullOrEmpty(textBox11.Text) ||
                string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text)
                ))
            {
                textBox21.Text = "Değer Giriniz!";
            }
            else
            {
                if ((k1.Yaricap + k2.Yaricap) > (int)d)
                {
                    textBox21.Text = "Çarpışma Var!";
                }
                else
                {
                    textBox21.Text = "Çarpışma Yok!";
                }
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
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
