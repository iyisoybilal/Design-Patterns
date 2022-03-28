using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer Kitap = new Urun("Kitap", 10);
            Kitap.TakipList.Add(new Uye { Email = "bilaliyisoy@hotmail.com" });
            Kitap.TakipList.Add(new Uye { Email = "hilaliyisoy@hotmail.com" });
            Kitap._Fiyat = 30;
            Console.ReadLine();


        }
    }
}
