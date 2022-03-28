using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    public abstract class Satıs
    {
        public virtual void GitarSatısYap()
        {
            Console.WriteLine("Gitar satisi yapıldı");
        }
        public virtual void KemenceSatısYap()
        {
            Console.WriteLine("Kemence satisi yapildi");
        }
    }
}
