using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    public class FactoryB : IFactory
    {
        private IProductA productA;
        private IProductB productB;
        public IProductA FactoryÜretA()
        {
            productA = new ProductA2();
            return productA;
        }
        public IProductB FactoryÜretB()
        {
            productB = new ProductB2();
            return productB;
        }
    }
}
