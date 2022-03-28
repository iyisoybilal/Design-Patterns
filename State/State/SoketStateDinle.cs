using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SoketStateDinle : ISoketState
    {
        public void Handle(Soket soket)
        {
            Console.WriteLine("{0} port soket dinleniyor",soket.Port);
            soket.State = new SoketStateKapat();        
        }
    }
}
