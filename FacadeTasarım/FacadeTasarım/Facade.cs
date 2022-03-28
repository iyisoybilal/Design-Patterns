using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeTasarım
{
   public class Facade
    {
       private Taksi Taksi;
       private Otel Otel;
       private Ucus Ucus;
        public Facade(string sinif,string BaslangicKonum,string HedefKonum)
        {
            Taksi = new Taksi(sinif);
            Otel = new Otel(sinif, HedefKonum);
            Ucus = new Ucus(sinif, HedefKonum, BaslangicKonum);
        }
        public void RezervasyonYap()
        {
            Taksi.TaksiCagir();
            Otel.OtelRez();
            Ucus.UcusYap();
        }
    }
}
