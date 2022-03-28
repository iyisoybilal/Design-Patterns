using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
   public abstract class Observer
    {
        public string  UrunAdi { get; set; }
        private int Fiyat;

        public List<IUye> TakipList = new List<IUye>();   
        public Observer(string urunAdi,int fiyat)
        {
            this.UrunAdi = urunAdi;
            this.Fiyat = fiyat;
        }
        public int _Fiyat
        {
            get { return Fiyat; }
            set
            {
                if (value > Fiyat)
                {
                    Notify();
                    Fiyat = value;
                }
            }
        }
        public void Notify()
        {
            foreach (var takip in TakipList)
            {
                takip.Uptade(this);
            }
        }
    }
}
