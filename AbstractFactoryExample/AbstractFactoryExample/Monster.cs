using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    public class Monster : IBilgisayarFirması
    {
        private IRam ram;
        private IHdd hdd;
        public IHdd hddÜret()
        {
             hdd= new MonsterHdd();
             return hdd;
        }

        public IRam ramÜret()
        {
            ram = new MonsterRam();
            return ram;
        }
    }
}
