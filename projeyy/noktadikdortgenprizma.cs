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
    public partial class noktadikdortgenprizma : Form
    {
        nokta3d n = new nokta3d();
        dikdortgenprizma dp = new dikdortgenprizma();
        public noktadikdortgenprizma()
        {
            InitializeComponent();
        }

        private void noktadikdortgenprizma_Load(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            dp.D = int.TryParse(textBox20.Text, out var value) ? value : dp.D;
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            n.Z = int.TryParse(textBox7.Text, out var value) ? value : n.Z;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            dp.M.X = int.TryParse(textBox11.Text, out var value) ? value : dp.M.X;
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

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            dp.Y = int.TryParse(textBox22.Text, out var value) ? value : dp.Y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double prizmaMinX = dp.M.X - (dp.G / 2);
            double prizmaMaxX = dp.M.X + (dp.G / 2);
            double primzaMinY = dp.M.Y - (dp.Y / 2);
            double primzaMaxY = dp.M.Y + (dp.Y / 2);
            double prizmaMinZ = dp.M.Z - (dp.D / 2);
            double prizmaMaxZ = dp.M.Z + (dp.D / 2);
            if ((string.IsNullOrEmpty(textBox22.Text) ||
                string.IsNullOrEmpty(textBox18.Text) ||
                string.IsNullOrEmpty(textBox15.Text) ||
                string.IsNullOrEmpty(textBox11.Text) ||
                string.IsNullOrEmpty(textBox13.Text) ||
                string.IsNullOrEmpty(textBox7.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox20.Text)
                ))
            {
                textBox16.Text = "Değer Giriniz!";
            }
            else
            {
                if ((n.X >= prizmaMinX && n.X <= prizmaMaxX) &&
                    (n.Y >= primzaMinY && n.Y <= primzaMaxY) &&
                    (n.Z >= prizmaMinZ && n.Z <= prizmaMaxZ))
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
