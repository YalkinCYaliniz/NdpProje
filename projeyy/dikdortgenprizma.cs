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
    public class dikdortgenprizma
    {
        private nokta3d m;
        private int genislik;
        private int yukseklik;
        private int derinlik;
        public dikdortgenprizma()
        {
            m = new nokta3d();
            genislik = 0;
            yukseklik = 0;
            derinlik = 0;
        }
        public dikdortgenprizma(nokta3d m,int genislik,int yukseklik,int derinlik)
        {
            this.m = m;
            this.genislik = genislik;
            this.derinlik = derinlik;
            this.genislik = genislik;
        }
        public nokta3d M
        {
            get { return m; }
            set { m = value; }
        }
        public int G
        {
            get { return genislik; }
            set { genislik = value; }
        }
        public int D
        {
            get { return derinlik; }
            set { derinlik = value; }
        }
        public int Y
        {
            get { return yukseklik; }
            set { yukseklik = value;}
        }

    }
}
