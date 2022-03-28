using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTasarım2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizzaBuilder pizzaBuilder = new KasarlıPizza();
            Dominos dominos = new Dominos();
            dominos.PizzaOlustur(pizzaBuilder);
            Console.WriteLine(pizzaBuilder.Pizza.MalzemeEkranBas());
            Console.ReadLine();
            
        }
    }
}
