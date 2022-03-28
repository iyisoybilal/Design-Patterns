using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarBuilder carBuilder = new BMW();
            ArabaÜret arabaÜret = new ArabaÜret();
            arabaÜret.Üret(carBuilder);
            Console.WriteLine(carBuilder.Car.Bilgi());
            ICarBuilder carBuilder1 = new Mercedes();
            arabaÜret.Üret(carBuilder1);
            Console.WriteLine(carBuilder1.Car.Bilgi());
            Console.ReadLine();


        }
    }
}
