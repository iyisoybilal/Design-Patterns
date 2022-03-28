using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTasarım
{
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;
        public Pizza Pizza
        {
            get { return pizza; }
        }
        public abstract void SosuHazirla();
        public abstract void HamuruHazirla();
    }
}
