using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample1
{
    public class Kredi
    {
        public void KrediKullan(Customer customer)
        {
            if (ControlManager.KrediKontrol(customer.IDNo))
            {
                Console.WriteLine("Krediniz onaylanmıştır");
            }
            else
                Console.WriteLine("Krediniz onaylanmamıştır");
        }
    }
}
