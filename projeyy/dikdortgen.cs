using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class dikdortgen
    {
        private int en;
        private int boy;
        private nokta merkez;
        public dikdortgen()
        {
            merkez = new nokta();
            en = 0; boy = 0;
        }
        public dikdortgen(nokta m, int en, int boy)
        {
            this.merkez = m;
            this.en = en;
            this.boy = boy;
        }
        public int En
        {
            get { return en; }
            set { en = value; }
        }
        public int Boy
        {
            get { return boy; }
            set { boy = value; }
        }
        public nokta Merkez
        {
            get { return merkez; }
            set { merkez = value; }
        }
    }
}
