using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ArabaOlusturucu
    {
        public IskeletOlustur iskelet { get; set; }
        public MotorOlusturucu motor { get; set; }
        public ArabaOlusturucu (IskeletOlustur iskelet, MotorOlusturucu motor)
        {
            this.iskelet = iskelet;
            this.motor = motor;    
        }
        public Araba Olustur(Renkler.ArabaRengi renk)
        {
            return new Araba(iskelet, motor, renk);
        }
        
    }
}
