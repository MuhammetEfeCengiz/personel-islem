using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personel_islem
{
    class personel
    {
        string tc;
        string ad;
        string soyad;
        string birim;
        int ibt;
        string dogumyeri;
        int dogumtarihi;
        public int prim(int kira, int satıs)
        {
            int maas = 2000;
            int s1= kira * 250;
            int s2 = satıs*500;
            return maas + s1 + s2;

        }
        public int tazminat (int yıl) 
        {
         
            if (yıl>=5)
            {
                return yıl * 1000;
            }
            else
            {
                return  0;
            }
            

        }


    }
}
