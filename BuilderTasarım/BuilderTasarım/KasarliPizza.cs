using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTasarım
{
    public class KasarliPizza:PizzaBuilder
    {
        public KasarliPizza()
        {
            pizza = new Pizza { PizzaTipi = "Kasarli" };
        }
        public override void SosuHazirla()
        {
            pizza.Sos= "Aci Sos";
        }
        public override void HamuruHazirla()
        {
            pizza.Hamur="İnce Hamur";
        }

    }
}
