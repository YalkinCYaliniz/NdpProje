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
    public class silindir
    {
        nokta3d m;
        int r;
        int h;
        public silindir()
        {
            m = new nokta3d();
            r = 0;
            h = 0;
        }
        public silindir(nokta3d m,int r, int h)
        {
            this.m = m;
            this.r = r;
            this.h = h;
        }
        public nokta3d M
        {
            get { return m; }
            set { m = value; }
        }
        public int R
        {
            get { return r; }
            set { r = value; }
        }
        public int H
        {
            get { return h; }
            set { h = value; }
        }
    }
}
