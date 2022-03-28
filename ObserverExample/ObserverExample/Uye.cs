using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    public class Uye : IUye
    {
        public string Email { get; set; }

        public void Uptade(Observer observer)
        {
            Console.WriteLine("{0} ın fiyatı {1}  oldu {2} adresine gönderildi",observer.UrunAdi,observer._Fiyat,Email);
        }
    }
}
