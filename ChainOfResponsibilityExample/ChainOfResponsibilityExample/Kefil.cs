using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public class Kefil : IKrediBasvuru
    {
        public override void BilgiGönder(Customer customer)
        {
            if (customer.Kefil == false)
            {
                Console.WriteLine("Kefil false kredi verilmez");
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
