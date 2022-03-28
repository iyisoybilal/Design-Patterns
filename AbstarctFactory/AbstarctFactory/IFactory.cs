using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
   public interface IFactory
    {
        IProductA FactoryÜretA();
        IProductB FactoryÜretB();
    }
}
