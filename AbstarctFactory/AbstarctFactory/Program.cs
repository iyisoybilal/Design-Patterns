using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryA factoryA = new FactoryA();
            IProductA productA=factoryA.FactoryÜretA();
            productA.ProductÜret();
            IProductB productB = factoryA.FactoryÜretB();
            productB.ProductÜret();
            //----------------------------------------------//
            FactoryB factoryB = new FactoryB();
            IProductA productA2 = factoryB.FactoryÜretA();
            productA2.ProductÜret();
            IProductB productB2 = factoryB.FactoryÜretB();
            productB2.ProductÜret();
            Console.ReadLine();
        }
    }
}
