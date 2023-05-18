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
    public partial class noktasilindir : Form
    {
        nokta3d n = new nokta3d();
        silindir s = new silindir();
        public noktasilindir()
        {
            InitializeComponent();
        }


        private void noktasilindir_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            n.Y = int.TryParse(textBox5.Text, out var value) ? value : n.Y;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            n.X = int.TryParse(textBox4.Text, out var value) ? value : n.X;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            n.Z = int.TryParse(textBox7.Text, out var value) ? value : n.Z;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            s.M.X = int.TryParse(textBox11.Text, out var value) ? value : s.M.X;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            s.M.Y = int.TryParse(textBox13.Text, out var value) ? value : s.M.Y;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            s.M.Z = int.TryParse(textBox14.Text, out var value) ? value : s.M.Z;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            s.H = int.TryParse(textBox17.Text, out var value) ? value : s.H;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            s.R = int.TryParse(textBox19.Text, out var value) ? value : s.R;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float dx = n.X - s.M.X;
            float dy = n.Y - s.M.Y;
            float dz = n.Z - s.M.Z;
            float h = s.H / 2;
            float r = s.R;
            if ((string.IsNullOrEmpty(textBox19.Text) ||
               string.IsNullOrEmpty(textBox17.Text) ||
               string.IsNullOrEmpty(textBox14.Text) ||
               string.IsNullOrEmpty(textBox11.Text) ||
               string.IsNullOrEmpty(textBox13.Text) ||
               string.IsNullOrEmpty(textBox7.Text)
               ))
            {
                textBox16.Text = "Değer Giriniz!";
            }
            else
            {
                if (dx * dx + dz * dz <= r*r && dy >= -h && dy<=h)
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
