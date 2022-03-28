using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{

    public class Factory
    {
        private IProduct product;
        public enum productTip
        {
            ProductA,
            ProductB
        }
        public IProduct FactoryUret(productTip tip)
        {
            switch (tip)
            {
                case productTip.ProductA:
                    product = new ProductA();
                    break;

                case productTip.ProductB:
                    product = new ProductB();
                    break;
                default:
                    Console.WriteLine("yanlıs secim");
                    break;

            }
            return product;
        }
    }
}


