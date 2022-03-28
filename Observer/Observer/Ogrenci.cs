using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Ogrenci
    {
        public string Adi { get; set; }
        public int Sinif { get; set; }
        public string Memleket { get; set; }

        bool dersAstiMi;
        public bool DersiAstiMi
        {
            get { return dersAstiMi; }
            set
            {
                if (value = true)
                {
                    Notify();
                    dersAstiMi = value;
                }
                else
                    dersAstiMi = value;
            }
        }
        List<Observer> Gözlemciler;
        public Ogrenci()
        {
            this.Gözlemciler = new List<Observer>();
        }
        public void AboneEkle(Observer observer)
        {
            Gözlemciler.Add(observer);
        }
        public void AboneCıkar(Observer observer)
        {
            Gözlemciler.Remove(observer);
        }
        public void Notify()
        {
            foreach (var gözlemciler in Gözlemciler)
            {
                gözlemciler.Uptade();
            }
        }
    }
}
