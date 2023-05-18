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
    public partial class dpdp : System.Windows.Forms.Form
    {
        dikdortgenprizma dp1 = new dikdortgenprizma();
        dikdortgenprizma dp2 = new dikdortgenprizma();
        public dpdp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            dp1.M.X = int.TryParse(textBox26.Text, out var value) ? value : dp1.M.X;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            dp1.M.Y = int.TryParse(textBox14.Text, out var value) ? value : dp1.M.Y;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            dp1.M.Z = int.TryParse(textBox11.Text, out var value) ? value : dp1.M.Z;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            dp1.G = int.TryParse(textBox9.Text, out var value) ? value : dp1.G;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dp1.D = int.TryParse(textBox3.Text, out var value) ? value : dp1.D;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dp1.Y = int.TryParse(textBox1.Text, out var value) ? value : dp1.Y;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            dp2.M.X = int.TryParse(textBox16.Text, out var value) ? value : dp2.M.X;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            dp2.M.Y = int.TryParse(textBox13.Text, out var value) ? value : dp2.M.Y;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            dp2.M.Z = int.TryParse(textBox15.Text, out var value) ? value : dp2.M.Z;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            dp2.G = int.TryParse(textBox18.Text, out var value) ? value : dp2.G;
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            dp2.D = int.TryParse(textBox20.Text, out var value) ? value : dp2.D;
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            dp2.Y = int.TryParse(textBox22.Text, out var value) ? value : dp2.Y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float mesafeX = Math.Abs(dp1.M.X - dp2.M.X);
            float mesafeY = Math.Abs(dp1.M.Y- dp2.M.Y);
            float mesafeZ = Math.Abs(dp1.M.Z - dp2.M.Z);
            bool xcarpisma = mesafeX <= dp1.G + dp2.G;
            bool ycarpisma = mesafeY <= dp1.Y + dp2.Y;
            bool zcarpisma = mesafeZ <= dp1.D + dp2.D;
            if (string.IsNullOrEmpty(textBox26.Text)||
                string.IsNullOrEmpty(textBox14.Text)||
                string.IsNullOrEmpty(textBox11.Text)||
                string.IsNullOrEmpty(textBox9.Text)||
                string.IsNullOrEmpty(textBox3.Text)||
                string.IsNullOrEmpty(textBox1.Text)||
                string.IsNullOrEmpty(textBox16.Text)||
                string.IsNullOrEmpty(textBox13.Text)||
                string.IsNullOrEmpty(textBox15.Text)||
                string.IsNullOrEmpty(textBox18.Text) ||
                string.IsNullOrEmpty(textBox20.Text) ||
                string.IsNullOrEmpty(textBox22.Text)

                )
            {
                textBox21.Text = "Değer Giriniz!";
            }
            else
            {
                if(xcarpisma && ycarpisma || xcarpisma && zcarpisma || ycarpisma && zcarpisma){
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
