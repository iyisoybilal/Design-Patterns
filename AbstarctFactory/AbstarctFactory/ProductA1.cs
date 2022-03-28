using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    public class ProductA1 : IProductA
    {
        public void ProductÜret()
        {
            Console.WriteLine("ProductA1 Üretildi");
        }
    }
}
