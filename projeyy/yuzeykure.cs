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
    public partial class yuzeykure : System.Windows.Forms.Form
    {
        yuzey yuzey = new yuzey();
        kure k = new kure();
        public yuzeykure()
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
            yuzey.solAltK.X = int.TryParse(textBox7.Text, out var value)?value: yuzey.solAltK.X;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            yuzey.solAltK.Y = int.TryParse(textBox5.Text, out var value) ? value : yuzey.solAltK.Y;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            yuzey.solAltK.Z = int.TryParse(textBox3.Text, out var value) ? value : yuzey.solAltK.Z;
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            yuzey.Genislik = int.TryParse(textBox23.Text, out var value) ? value : yuzey.Genislik;
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            yuzey.Derinlik = int.TryParse(textBox20.Text, out var value) ? value : yuzey.Derinlik;
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            yuzey.Yukseklik = int.TryParse(textBox22.Text, out var value) ? value : yuzey.Yukseklik;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            k.M.X = int.TryParse(textBox11.Text, out var value) ? value : k.M.Z;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            k.M.Y = int.TryParse(textBox13.Text, out var value) ? value : k.M.Y;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            k.M.Z = int.TryParse(textBox18.Text, out var value) ? value : k.M.Z;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            k.Yaricap = int.TryParse(textBox15.Text, out var value) ? value : k.Yaricap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float yuzeyMerkezX = yuzey.solAltK.X + (yuzey.Genislik / 2);
            float yuzeyMerkezY = yuzey.solAltK.Y + (yuzey.Yukseklik / 2);
            float yuzeyMerkezZ = yuzey.solAltK.Z + (yuzey.Derinlik / 2);

            float distance = (float)Math.Sqrt(Math.Pow(k.M.X - yuzeyMerkezX, 2) + Math.Pow(k.M.Y - yuzeyMerkezY, 2) + Math.Pow(k.M.Z - yuzeyMerkezZ, 2));
            if ((string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox23.Text) ||
                string.IsNullOrEmpty(textBox20.Text) ||
                string.IsNullOrEmpty(textBox22.Text) ||
                string.IsNullOrEmpty(textBox11.Text) ||
                string.IsNullOrEmpty(textBox13.Text) ||
                string.IsNullOrEmpty(textBox18.Text) ||
                string.IsNullOrEmpty(textBox15.Text) ||
                string.IsNullOrEmpty(textBox7.Text)
                ))
            {
                textBox25.Text = "Değer Giriniz!";
            }
            else
            {
                if(distance <= k.Yaricap)
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
