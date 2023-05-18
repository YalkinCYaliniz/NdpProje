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
    public partial class kuredikdortgenprizma : System.Windows.Forms.Form
    {
        kure k = new kure();
        dikdortgenprizma dp = new dikdortgenprizma();
        public kuredikdortgenprizma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            k.M.X = int.TryParse(textBox11.Text, out var value) ? value : k.M.X;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            k.M.Y = int.TryParse(textBox1.Text, out var value) ? value : k.M.Y;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            k.M.Z = int.TryParse(textBox2.Text, out var value) ? value : k.M.Z;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            k.Yaricap = int.TryParse(textBox3.Text, out var value) ? value : k.Yaricap;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            dp.M.X = int.TryParse(textBox16.Text, out var value) ? value : dp.M.X;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            dp.M.Y = int.TryParse(textBox13.Text, out var value) ? value : dp.M.Y;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            dp.M.Z = int.TryParse(textBox15.Text, out var value) ? value : dp.M.Z;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            dp.G = int.TryParse(textBox18.Text, out var value) ? value : dp.G;
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            dp.D = int.TryParse(textBox20.Text, out var value) ? value : dp.D;
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            dp.Y = int.TryParse(textBox22.Text, out var value) ? value : dp.Y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float deltaX = Math.Abs(k.M.X - dp.M.X);
            float deltaY = Math.Abs(k.M.Y - dp.M.Y);
            float deltaZ = Math.Abs(k.M.Z - dp.M.Z);

            float distance = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
            if ((string.IsNullOrEmpty(textBox11.Text) ||
                string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox13.Text) ||
                string.IsNullOrEmpty(textBox16.Text) ||
                string.IsNullOrEmpty(textBox15.Text) ||
                string.IsNullOrEmpty(textBox18.Text) ||
                string.IsNullOrEmpty(textBox20.Text) ||
                string.IsNullOrEmpty(textBox22.Text)
                ))
            {
                textBox21.Text = "Değer Giriniz!";
            }
            else
            {
                if (distance <= k.Yaricap + (float)Math.Sqrt(dp.G * dp.G + dp.Y * dp.Y + dp.D * dp.D) / 2f)
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
    }
}
