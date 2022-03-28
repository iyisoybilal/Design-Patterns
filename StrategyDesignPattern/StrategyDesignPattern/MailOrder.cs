using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class MailOrder : IOdemeYontem
    {
        public void Ode()
        {
            Console.WriteLine("Mail Order yöntemi ile ödendi");
        }
    }
}
