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
    public partial class noktakure : Form
    {
        nokta3d n = new nokta3d();
        kure k = new kure();
        public noktakure()
        {
            InitializeComponent();
        }

        private void noktakure_Load(object sender, EventArgs e)
        {

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
            k.M.X = int.TryParse(textBox11.Text, out var value) ? value : k.M.X;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            k.M.Y = int.TryParse(textBox13.Text, out var value) ? value : k.M.Y;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            k.Yaricap = int.TryParse(textBox15.Text, out var value) ? value : k.Yaricap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float mesafe = (float)Math.Sqrt(Math.Pow(n.X - k.M.X, 2) + Math.Pow(n.Y - k.M.Y, 2) + Math.Pow(n.Z - k.M.Z, 2));

            if ((string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox7.Text) ||
                string.IsNullOrEmpty(textBox11.Text) ||
                string.IsNullOrEmpty(textBox13.Text) ||
                string.IsNullOrEmpty(textBox18.Text) ||
                string.IsNullOrEmpty(textBox15.Text)
                ))
            {
                textBox16.Text = "Değer Giriniz!";
            }
            else
            {
                if (mesafe <= k.Yaricap)
                {

                    textBox16.Text = "Çarpışma Var!";
                }
                else
                {
                    textBox16.Text = "Çarpışma Yok!";
                }
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            k.M.Z = int.TryParse(textBox18.Text, out var result) ? result : k.M.Z;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
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
