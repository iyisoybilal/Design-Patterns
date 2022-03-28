using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        public int Fiyat { get; set; }

        public List<Observer> TeklifVerenler;
        public Urun(string UrunAdi, int Fiyat)
        {
            this.UrunAdi = UrunAdi;
            this.Fiyat = Fiyat;
        }
        public String UrunAd
        {
            get { return UrunAdi; }
            set
            {
                this.UrunAdi = UrunAd;
            }
        }
        public int Teklif
        {
            get { return Fiyat; }
            set
            {
                this.Fiyat = Teklif;
            }
        }

        public void TeklifVer(Observer observer)
        {
            TeklifVerenler.Add(observer);
        }
        public void Notify()
        {
            foreach (var teklifler in TeklifVerenler)
            {
                teklifler.Uptade();
            }
        }

    }
}
