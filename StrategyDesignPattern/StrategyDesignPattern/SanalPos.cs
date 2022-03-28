using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class SanalPos : IOdemeYontem
    {
        public void Ode()
        {
            Console.WriteLine("Sanal Pos ile ödendi");
        }
    }
}
