using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public class Firma : IKrediBasvuru
    {
        public override void BilgiGönder(Customer customer)
        {
            if (customer.Kurumsal == false)
            {
                Console.WriteLine("Kurumsal Firma false kredi verilmez");
            }
            else
            {
                Console.WriteLine("Kredi verilmiştir");
            }
        }
    }
}
