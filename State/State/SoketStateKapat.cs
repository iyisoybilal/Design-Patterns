using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SoketStateKapat : ISoketState
    {
        public void Handle(Soket soket)
        {
            Console.WriteLine("{0} port soket kapatılıyor",soket.Port);
            soket.State = new SoketStateAc();
        }
    }
}
