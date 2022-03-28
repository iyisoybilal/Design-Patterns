using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample1
{
    public class Facade
    {
        private EFT eft;
        private Kredi kredi;
        public Facade()
        {
            eft = new EFT();
            kredi = new Kredi();
        }
        public void SendEft(Customer fromCustomer,Customer toCustomer,decimal eftAmount)
        {
            eft.SendEft(fromCustomer, toCustomer, eftAmount);
        }
        public void KrediKullan(Customer customer)
        {
            kredi.KrediKullan(customer);
        }
    }
}
