using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeTasarım
{
    public class Otel
    {
      private string sinif;
      private  string HedefKonum;
        public Otel(string sinif,string HedefKonum)
        {
            this.sinif = sinif;
            this.HedefKonum = HedefKonum;
        }
        public void OtelRez()
        {
            Console.WriteLine(sinif + " klasında" + HedefKonum +"  " + "konum için rezervasyon yapildi");
        }
    }
}
