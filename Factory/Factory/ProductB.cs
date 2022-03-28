using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ProductB : IProduct
    {
        public void ProductÜret()
        {
            Console.WriteLine("ProductB Üretildi");
        }
    }
}
