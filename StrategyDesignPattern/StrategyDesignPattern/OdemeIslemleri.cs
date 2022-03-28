using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class OdemeIslemleri
    {
        private IOdemeYontem odemeYontem;
        public OdemeIslemleri(IOdemeYontem odemeYontem)
        {
            this.odemeYontem = odemeYontem;
        }
        public void Pay()
        {
            this.odemeYontem.Ode();
        }
    }
}
