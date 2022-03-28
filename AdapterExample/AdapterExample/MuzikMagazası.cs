using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    public class MuzikMagazası:Satıs
    {
        private Kemence kemence = new Kemence();
        private Gitar gitar = new Gitar();
        public override void KemenceSatısYap()
        {
            kemence.KemenceSat();
        }
        public override void GitarSatısYap()
        {
            gitar.GitarSat();
        }

    }
}
