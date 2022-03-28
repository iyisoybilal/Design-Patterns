using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public class AylıkGelir : IKrediBasvuru
    {
        public override void BilgiGönder(Customer customer)
        {
            if (customer.Gelir <1000)
            {
                Console.WriteLine("Gelir false kredi verilmez");
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
