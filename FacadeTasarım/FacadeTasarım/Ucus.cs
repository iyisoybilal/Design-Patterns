using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeTasarım
{
    public class Ucus
    {
       private string sinif;
       private string HedefKonum;
       private string BaslangicKonum;
        public Ucus(string sinif,string HedefKonum,string BaslangicKonum)
        {
            this.sinif = sinif;
            this.HedefKonum = HedefKonum;
            this.BaslangicKonum = BaslangicKonum;
        }
        public void UcusYap()
        {
            Console.WriteLine(sinif + "klasında" + BaslangicKonum + "konumundan" + HedefKonum + "konumuna ucus yapıldı");
        }
    }
}
