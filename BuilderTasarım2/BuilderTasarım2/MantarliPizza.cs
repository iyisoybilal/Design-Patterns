using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTasarım2
{
    public class MantarliPizza : IPizzaBuilder
    {
        
        public MantarliPizza()
        {
            pizza = new Pizza();
        }

        public override void HamurSec()
        {
            pizza.Hamur = "Kalın Hamur";
        }

        public override void PizzaSec()
        {
            pizza.PizzaTipi = "Mantarli";
        }

        public override void SosSec()
        {
            pizza.Sos = "Salcali";
        }
    }
}
