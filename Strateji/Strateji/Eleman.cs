using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strateji
{
    public class Eleman
    {
        public İzinHesapla izinHesap;
        public MaasHesapla maasHesap;
        public Eleman(İzinHesapla izinHesap,MaasHesapla maasHesap)
        {
            this.izinHesap = izinHesap;
            this.maasHesap = maasHesap;
        }
        public int İzinHesapla()
        {
            return izinHesap.izinHesapla();
        }
        public int MaasHesapla()
        {
            return maasHesap.MaasHesapla();
        }
    }
}
