using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTasarım
{
   public class Pideci
    {
        public void Olustur(PizzaBuilder pizza)
        {
            pizza.SosuHazirla();
            pizza.HamuruHazirla();
        }
    }
}
