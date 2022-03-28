using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    public class CasperRam : IRam
    {
        public void ParcaÜret()
        {
            Console.WriteLine("Casper Ram Üretildi");
        }
    }
}
