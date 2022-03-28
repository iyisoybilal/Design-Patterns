using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
   public class ArabaÜret
    {
        public void Üret(ICarBuilder CarBuilder)
        {
            CarBuilder.Marka();
            CarBuilder.Model();
            CarBuilder.Yıl();
        }
    }
}
