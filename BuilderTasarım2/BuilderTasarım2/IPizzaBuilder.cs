using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTasarım2
{
    public abstract class IPizzaBuilder
    {
        protected Pizza pizza;
        public Pizza Pizza
        {
            get { return pizza; }
        }
       public abstract void PizzaSec();
       public abstract void HamurSec();
       public abstract void SosSec();
    }
}
