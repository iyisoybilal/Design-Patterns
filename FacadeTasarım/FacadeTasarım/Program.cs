using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeTasarım
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade("Business","Antalya","Ankara");
            facade.RezervasyonYap();
            Console.ReadLine();

        }
    }
}
