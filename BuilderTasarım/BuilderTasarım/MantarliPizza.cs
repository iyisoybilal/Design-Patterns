using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTasarım
{
    public class MantarliPizza:PizzaBuilder
    {
        public MantarliPizza()
        {
            pizza = new Pizza { PizzaTipi = "Mantarli" };
        }
        public override void HamuruHazirla()
        {
            pizza = new Pizza { Hamur = "Kalin Hamur" };
        }
        public override void SosuHazirla()
        {
            pizza = new Pizza { Sos = "Acisiz Sos" };
        }
    }
}
