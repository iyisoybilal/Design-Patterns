using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTasarım2
{
   public class Dominos
    {
        public void PizzaOlustur(IPizzaBuilder pizzaBuilder)
        {
            pizzaBuilder.HamurSec();
            pizzaBuilder.SosSec();
            pizzaBuilder.PizzaSec();
            
        }
    }
}
