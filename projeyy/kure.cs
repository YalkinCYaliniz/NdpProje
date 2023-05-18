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
    public class kure
    {
        nokta3d m;
        int yaricap;
        public kure() { 
            m = new nokta3d();
            yaricap = 0;
        }
        public kure(nokta3d m,int yaricap) {
            this.m = m;
            this.yaricap = yaricap;
        }
        public nokta3d M
        {
            get { return m; }
            set { m = value; }
        }
        public int Yaricap
        {
            get { return yaricap; }
            set { yaricap = value; }
        }
    }
}
