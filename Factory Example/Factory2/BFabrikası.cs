using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2
{
    public class BFabrikası : IFabrika
    {
        public ISınıf sınıf()
        {
            return new BSinifi();
        }
    }
}
