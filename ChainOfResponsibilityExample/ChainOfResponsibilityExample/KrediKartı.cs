using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public class KrediKartı : IKrediBasvuru
    {
        public override void BilgiGönder(Customer customer)
        {
            if (customer.KrediKart == false)
            {
                Console.WriteLine("Kredi kart false kredi verilmez");
            }
            else
            {
                if (krediBasvuru != null)
                {
                    krediBasvuru.BilgiGönder(customer);
                }
            }
        }
    }
}
