using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { KBB = 1500, KrediKart = false, Kefil = false, Gelir = 1800, Kurumsal = true, Ad = "Bilal" };
            IKrediBasvuru Kbb = new KBB();
            IKrediBasvuru kredi = new KrediKartı();
            IKrediBasvuru Kefil = new Kefil();
            IKrediBasvuru gelir = new AylıkGelir();
            IKrediBasvuru firma = new Firma();

            Kbb.SonrakiKontrol = kredi;
            Kbb.SonrakiKontrol = Kefil;
            Kbb.SonrakiKontrol = gelir;
            Kbb.SonrakiKontrol = firma;
            Kbb.BilgiGönder(customer);
           
            
            Console.ReadLine();

        }
    }
}
