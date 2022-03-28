using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Araba
    {
        public Araba (IskeletOlustur iskelet,MotorOlusturucu motor,Renkler.ArabaRengi renk)
        {
            Console.WriteLine($"iskelet a = {iskelet.a}");
            Console.WriteLine($"iskelet b = {iskelet.b}");
            Console.WriteLine($"iskelet z = {iskelet.z}");
            Console.WriteLine($"Motor x ={motor.x}");
            Console.WriteLine($"Motor y ={motor.y}");
            Console.WriteLine($"Motor z ={motor.z}");
            Console.WriteLine($"Renk {renk}");
        }
    }
}
