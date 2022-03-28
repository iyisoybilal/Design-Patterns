using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityFinal
{
    public abstract class ParaCek
    {
        public int miktar = 40;
        protected ParaCek paraCek;
        public ParaCek Sonraki
        {
            set
            {
                paraCek = value;
            }
        }
        public abstract void BilgiGönder(Musteri musteri);
    }
}
