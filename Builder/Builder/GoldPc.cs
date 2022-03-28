using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class GoldPc : IBilgisayarToplayici
    {
        public void HddÜret()
        {
            Console.WriteLine("GoldPc=GoldHdd'e Sahip");
        }

        public void RamÜret()
        {
            Console.WriteLine("GoldPc=GoldRam'e Sahip");
        }
    }
}
