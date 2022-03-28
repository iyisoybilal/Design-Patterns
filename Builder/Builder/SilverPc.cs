using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SilverPc : IBilgisayarToplayici
    {
        public void HddÜret()
        {
            Console.WriteLine("SiverPc=SilverHdd'e Sahip");
        }

        public void RamÜret()
        {
            Console.WriteLine("SilverPc=SilverRam'e Sahip");
        }
    }
}
