using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterTasarım
{
    public class Adapter : Satıs
    {
        private Adaptee adaptee = new Adaptee();
        public void siparisVer()
        {
            adaptee.KemenceSatıs();
        }
    }
}
