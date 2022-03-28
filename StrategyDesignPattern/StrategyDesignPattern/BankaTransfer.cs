using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class BankaTransfer : IOdemeYontem
    {
        public void Ode()
        {
            Console.WriteLine("Banka transfer yöntemi ile ödendi");
        }
    }
}
