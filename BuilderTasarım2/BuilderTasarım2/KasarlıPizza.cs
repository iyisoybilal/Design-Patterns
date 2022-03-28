using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTasarım2
{
    public class KasarlıPizza : IPizzaBuilder
    {
        public KasarlıPizza()
        {
            pizza = new Pizza();
        }
        public override void HamurSec()
        {
            pizza.Hamur = "İnce Hamur";
        }

        public override void PizzaSec()
        {
            pizza.PizzaTipi = "Kasarli";
        }

        public override void SosSec()
        {
            pizza.Sos = "Aci Sos";
        }
    }
}
