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
****************************************************************************/using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeyy
{
    public partial class silindiryuzey : System.Windows.Forms.Form
    {
        yuzey y = new yuzey();
        silindir s = new silindir();
        public silindiryuzey()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            y.solAltK.X = int.TryParse(textBox7.Text, out var value) ? value : y.solAltK.X;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            y.solAltK.Y = int.TryParse(textBox5.Text, out var value) ? value : y.solAltK.Y;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            y.solAltK.Z = int.TryParse(textBox3.Text, out var value) ? value : y.solAltK.Z;
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            y.Genislik = int.TryParse(textBox23.Text, out var value) ? value : y.Genislik;
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            y.Derinlik = int.TryParse(textBox20.Text, out var value) ? value : y.Derinlik;
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            y.Yukseklik = int.TryParse(textBox22.Text, out var value) ? value : y.Yukseklik;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            s.M.X = int.TryParse(textBox14.Text, out var value) ? value : s.M.X;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            s.M.Z = int.TryParse(textBox11.Text, out var value) ? value : s.M.Z;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            s.M.Y = int.TryParse(textBox12.Text, out var value) ? value : s.M.Y;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            s.H = int.TryParse(textBox9.Text, out var value) ? value : s.H;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            s.R = int.TryParse(textBox8.Text, out var value) ? value : s.R;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float maxX = y.solAltK.X + y.Genislik;
            float maxY = y.solAltK.Y + y.Yukseklik;
            float maxZ = y.solAltK.Z + y.Derinlik;

            float sMinX = s.M.X - s.R;
            float sMaxX = s.M.X + s.R;
            float sMaxY = s.M.Y + s.R;
            float sMinZ = s.M.Z - s.R;
            float sinMaxZ = s.M.Z + s.R;

            if ((string.IsNullOrEmpty(textBox8.Text) ||
                string.IsNullOrEmpty(textBox9.Text) ||
                string.IsNullOrEmpty(textBox12.Text) ||
                string.IsNullOrEmpty(textBox11.Text) ||
                string.IsNullOrEmpty(textBox14.Text) ||
                string.IsNullOrEmpty(textBox22.Text) ||
                string.IsNullOrEmpty(textBox20.Text) ||
                string.IsNullOrEmpty(textBox23.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox5.Text)||              
                string.IsNullOrEmpty(textBox7.Text)
                ))
            {
                textBox25.Text = "Değer Giriniz!";
            }
            else
            {
                if (sMinX <= maxX && sMaxX >= y.solAltK.X &&
                    s.M.Y <= maxY && sMaxX >= y.solAltK.Y &&
                    sMinZ <= maxZ && sinMaxZ >= y.solAltK.Z)
                    
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
