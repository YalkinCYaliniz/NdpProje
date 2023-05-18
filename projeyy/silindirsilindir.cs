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
    public partial class silindirsilindir : Form
    {
        silindir s1 = new silindir();
        silindir s2 = new silindir();
        public silindirsilindir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            s1.M.X = int.TryParse(textBox11.Text, out var value) ? value : s1.M.X;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            s1.M.Y = int.TryParse(textBox3.Text, out var value) ? value : s1.M.Y;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            s1.M.Z = int.TryParse(textBox4.Text, out var value) ? value : s1.M.Z;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            s1.H = int.TryParse(textBox5.Text, out var value) ? value : s1.H;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            s1.R = int.TryParse(textBox6.Text, out var value) ? value : s1.R;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            s2.M.X = int.TryParse(textBox13.Text, out var value) ? value : s2.M.X;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            s2.M.Y = int.TryParse(textBox16.Text, out var value) ? value : s2.M.Y;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            s2.M.Z = int.TryParse(textBox19.Text, out var value) ? value : s2.M.Z;
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            s2.H = int.TryParse(textBox22.Text, out var value) ? value : s2.H;
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            s2.R = int.TryParse(textBox24.Text, out var value) ? value : s2.R;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nokta3d pa = new nokta3d(s1.M.X, s1.M.Y + s1.H / 2, s1.M.Z);
            nokta3d pb = new nokta3d(s2.M.X,s2.M.Y + s2.H / 2, s2.M.Z);
            float d = (float)Math.Sqrt(Math.Pow((pa.X - pb.X), 2) + Math.Pow((pa.Y - pb.Y), 2) + Math.Pow((pa.Z - pb.Z), 2));
            if ((string.IsNullOrEmpty(textBox24.Text) ||
                string.IsNullOrEmpty(textBox22.Text) ||
                string.IsNullOrEmpty(textBox19.Text) ||
                string.IsNullOrEmpty(textBox16.Text) ||
                string.IsNullOrEmpty(textBox13.Text) ||
                string.IsNullOrEmpty(textBox6.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox11.Text)
                ))
            {
                textBox25.Text = "Değer Giriniz!";
            }
            else
            {
                if((s1.R + s2.R) > (int)d && Math.Abs(pa.Y - pb.Y) < ((s1.H + s2.H) / 2))
                {
                    textBox25.Text = "Çarpışma Var!";
                }
                else
                {
                    textBox25.Text = "Çarpışma Yok!";
                }
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
