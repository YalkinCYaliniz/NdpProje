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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dikdortgendikdortgen cs = new dikdortgendikdortgen();
            cs.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            noktakure cs = new noktakure();
            cs.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            kurekure cs = new kurekure();
            cs.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            yuzeydikdortgenprizma cs = new yuzeydikdortgenprizma();
            cs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            noktadikdortgen cs = new noktadikdortgen();
            cs.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            noktacember cs = new noktacember();
            cs.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dikdortgencember cs = new dikdortgencember();
            cs.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cembercember cs = new cembercember();
            cs.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            noktadikdortgenprizma cs = new noktadikdortgenprizma();
            cs.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            noktasilindir cs = new noktasilindir();
            cs.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            silindirsilindir cs = new silindirsilindir();
            cs.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            kuresilindir cs = new kuresilindir();
            cs.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            yuzeykure cs = new yuzeykure();
            cs.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            silindiryuzey cs = new silindiryuzey();
            cs.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            kuredikdortgenprizma cs = new kuredikdortgenprizma();
            cs.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            dpdp cs = new dpdp();
            cs.Show();
            this.Hide();
        }
    }
}