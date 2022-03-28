using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    public class Urun:Observer
    {
        public Urun(string urunAdi,int fiyat) : base(urunAdi, fiyat)
        {

        }
    }
}
