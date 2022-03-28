using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityFinal
{
    public class Vezne : ParaCek
    {
        public override void BilgiGönder(Musteri musteri)
        {
            if (musteri.Miktar < miktar)
            {
                Console.WriteLine("Para Cekimi basarıyla gerçekleşmiştir");
            }
            else
            {
                if(Sonraki != null)
                {
                    Sonraki.BilgiGönder(musteri);
                }
            }
        }
    }
}
