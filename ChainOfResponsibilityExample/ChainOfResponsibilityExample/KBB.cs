using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public class KBB : IKrediBasvuru
    {
        public override void BilgiGönder(Customer customer)
        {
            
            if (customer.KBB <= 1000)
            {
                Console.WriteLine("KBB false kredi verilmez");
                
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
