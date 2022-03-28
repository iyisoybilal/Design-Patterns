using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    public class Casper : IBilgisayarFirması
    {
        private IHdd hdd;
        private IRam ram;
        public IHdd hddÜret()
        {
            hdd = new CasperHdd();
            return hdd;
        }

        public IRam ramÜret()
        {
            ram = new CasperRam();
            return ram;
        }
    }
}
