using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTasarım
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBuilder pizza;
            Pideci pideci = new Pideci();
            pizza = new KasarliPizza();
            pideci.Olustur(pizza);
            Console.WriteLine(pizza.Pizza.ToString());
            Console.ReadLine();



        }
    }
}
