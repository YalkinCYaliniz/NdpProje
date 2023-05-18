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
    public class nokta3d : nokta
    {
        private int z;
        public nokta3d() : base() { 
        z = 0;
        }
        public nokta3d(int x, int y, int z)
        {
            this.z = z;
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }

    }
}
