using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IBilgisayarFirması bilgisayarFirması = new Casper();
            IHdd hdd = bilgisayarFirması.hddÜret();
            hdd.ParcaÜret();
            IRam ram = bilgisayarFirması.ramÜret();
            ram.ParcaÜret();
            IBilgisayarFirması bilgisayarFirması1= new Monster();
            IRam ram1 = bilgisayarFirması1.ramÜret();
            ram1.ParcaÜret();
            IHdd hdd1 = bilgisayarFirması1.hddÜret();
            hdd1.ParcaÜret();
            Console.ReadLine();
        }
    }
}
