using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    public class Facade
    {
        private Banka banka;
        private Kredi kredi;
        private MerkezBanka merkezBanka;
        public Facade()
        {
            banka = new Banka();
            kredi = new Kredi();
            merkezBanka = new MerkezBanka();
        }
        public void  KrediKullan(Musteri m,decimal talep)
        {
            if (merkezBanka.KaraListeKontrolu(m.TC) && kredi.KrediKullanmaDurumu(m))
            {
                banka.KrediyiKullan(m, talep);
                Console.WriteLine("Krediyi kullandırdık");
            }
        } 
    }
}
