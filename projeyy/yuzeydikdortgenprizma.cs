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
    public partial class yuzeydikdortgenprizma : System.Windows.Forms.Form
    {
        dikdortgenprizma dp = new dikdortgenprizma();
        yuzey y = new yuzey();
        public yuzeydikdortgenprizma()
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
            y.Genislik =  int.TryParse(textBox23.Text, out var value) ? value : y.Genislik;
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            y.Derinlik = int.TryParse(textBox20.Text, out var value) ? value : y.Derinlik;
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            y.Yukseklik = int.TryParse(textBox22.Text, out var value) ? value : y.Yukseklik;
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            dp.M.X = int.TryParse(textBox26.Text, out var value) ? value : dp.M.X;
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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            dp.D = int.TryParse(textBox10.Text, out var value) ? value : dp.D;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            dp.Y = int.TryParse(textBox8.Text, out var value) ? value : dp.Y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float dpMinX = dp.M.X - (dp.G / 2f);
            float dpMaxX = dp.M.X + (dp.G / 2f);
            float dpMinY = dp.M.Y - (dp.Y / 2f);
            float dpMaxY = dp.M.Y + (dp.Y / 2f);
            float dpMinZ = dp.M.Z - (dp.D / 2f);
            float dpMaxZ = dp.M.Z + (dp.D / 2f);

            float yuzeyMaxX = y.solAltK.X + y.Genislik;
            float yuzeyMaxY = y.solAltK.Y + y.Yukseklik;
            float yuzeyMaxZ = y.solAltK.Z + y.Derinlik;

            if((string.IsNullOrEmpty(textBox8.Text)||
                string.IsNullOrEmpty(textBox10.Text)||
                string.IsNullOrEmpty(textBox15.Text) ||
                string.IsNullOrEmpty(textBox13.Text) ||
                string.IsNullOrEmpty(textBox26.Text) ||
                string.IsNullOrEmpty(textBox22.Text) ||
                string.IsNullOrEmpty(textBox20.Text) ||
                string.IsNullOrEmpty(textBox23.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox17.Text)
                ))
            {
                textBox25.Text = "Değer Giriniz!";
            }

            else
            {
                if (dpMinX < yuzeyMaxX && dpMaxX > y.solAltK.X &&
                    dpMinY < yuzeyMaxY && dpMaxY > y.solAltK.Y &&
                    dpMinZ < yuzeyMaxZ && dpMaxZ > y.solAltK.Z)
                    
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
