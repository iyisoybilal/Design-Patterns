using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    public class FactoryA : IFactory
    {
        private IProductA productA;
        private IProductB productB;
        public IProductA FactoryÜretA()
        {
            productA = new ProductA1();
            return productA;
        }
        public IProductB FactoryÜretB()
        {
            productB = new ProductB1();
            return productB;
        }

    }
}
