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
    public partial class kuresilindir : Form
    {
        kure k = new kure();
        silindir s = new silindir();
        public kuresilindir()
        {
            InitializeComponent();
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            s.H = int.TryParse(textBox4.Text, out var value) ? value : s.H;
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            s.M.Z = int.TryParse(textBox5.Text, out var value) ? value : s.M.Z;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            s.M.Y = int.TryParse(textBox13.Text, out var value) ? value : s.M.Y;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            s.M.X = int.TryParse(textBox7.Text, out var value) ? value : s.M.X;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            s.R = int.TryParse(textBox19.Text, out var value) ? value : s.R;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float distance = (float)Math.Sqrt(Math.Pow(k.M.X - s.M.X, 2) +
                                       Math.Pow(k.M.Y - s.M.Y, 2) +
                                       Math.Pow(k.M.Z - s.M.Z, 2));
            float height = (float)Math.Abs(k.M.Y - s.M.Y);
            float rToplam = k.Yaricap + s.R;
            if ((string.IsNullOrEmpty(textBox7.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox19.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox13.Text) ||
                string.IsNullOrEmpty(textBox11.Text) ||
                string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text)
                ))
            {
                textBox23.Text = "Değer Giriniz!";
            }
            else
            {
                if(distance <= rToplam && height <= s.R)
                {
                    textBox23.Text = "Çarpışma Var!";
                }
                else
                {
                    textBox23.Text = "Çarpışma Yok!";
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
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

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
