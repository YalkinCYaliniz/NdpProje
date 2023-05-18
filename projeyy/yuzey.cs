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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeyy
{
    public class yuzey
    {
        private nokta3d solAltKose;
        private int derinlik;
        private int genislik;
        private int yukseklik;

        public yuzey()
        {
            solAltKose = new nokta3d();
            derinlik = 0;
            genislik = 0;
            yukseklik = 0;
        }
        public yuzey(nokta3d solAltKose, int derinlik, int genislik, int yukseklik)
        {
            this.yukseklik = yukseklik;
            this.derinlik = derinlik;
            this.genislik = genislik;
            this.solAltKose = solAltKose;
        }
        public nokta3d solAltK
        {
            get { return solAltKose; }
            set { solAltKose = value; }
        }
        public int Derinlik{
            get { return derinlik; }
            set { derinlik = value; }

        }
        public int Genislik { get {  return genislik; } set { genislik = value; } }
        public int Yukseklik { get { return yukseklik; } set {  yukseklik = value; } }
    }
}
