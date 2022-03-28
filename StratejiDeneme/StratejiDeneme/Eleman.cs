using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratejiDeneme
{
    public class Eleman
    {

        public İzinHesap izinHesap;
        public MaasHesapla maasHesapla;
        

        public Eleman (İzinHesap izinHesap,MaasHesapla maasHesapla)
        {
            this.maasHesapla = maasHesapla;
            this.izinHesap = izinHesap;
        }
        public int İzinHesap()
        {
            return izinHesap.İzinHesap();  
        }
        public int MaasHesap()
        {
            return maasHesapla.MaasHesapla();
        }
    }
}
