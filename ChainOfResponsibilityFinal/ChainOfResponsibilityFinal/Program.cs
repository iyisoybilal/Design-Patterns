using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri { Ad = "Bilal", Miktar = 30 };
            ParaCek paraCek = new Vezne();
            ParaCek paraCek1 = new Yönetici();
            ParaCek paraCek2 = new Müdür();

            paraCek.Sonraki = paraCek1;
            paraCek1.Sonraki = paraCek2;

            paraCek.BilgiGönder(musteri);
            Console.ReadLine();
        }
    }
}
