using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.AboneEkle(new BabaObserver());
            ogrenci.AboneCıkar(new AnneObserver());


            ogrenci.Adi = "Bilal";
            ogrenci.Memleket = "Erzurum";
            ogrenci.Sinif = 22;
            ogrenci.DersiAstiMi = false;
            Console.ReadLine();

        }
    }
}
