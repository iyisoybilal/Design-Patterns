using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class FacadeUretici
    {
        IskeletOlustur iskelet;
        MotorOlusturucu motor;
        ArabaOlusturucu olustur;
        public FacadeUretici()
        {
            iskelet = new IskeletOlustur() { a = 3, b = 4, z = true };
            motor = new MotorOlusturucu() { x = 5, y = 1, z = false };
            olustur = new ArabaOlusturucu(iskelet, motor);
        }
        public void ArabaUret()
        {
            Araba ÜretilenAraba = olustur.Olustur(Renkler.ArabaRengi.Kırmızı);
        }
    }
}
