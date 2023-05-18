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
    public class cember
    {
        private int yaricap;
        private nokta merkez;
        public cember()
        {
            yaricap = 0;
            merkez = new nokta();
        }
        public cember(int yaricap,nokta merkez)
        {
            this.yaricap = yaricap;
            this.merkez = merkez;
        }
        public nokta Merkez
        {
            get { return merkez; }
            set { merkez = value; }
        }
        public int Yaricap
        {
            get { return yaricap; }
            set { yaricap = value; }
        }
    }
}
