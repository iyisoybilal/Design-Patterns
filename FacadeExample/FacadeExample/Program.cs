using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.KrediKullan(new Musteri { Ad = "Bilal", MüsteriNumarası = 123456, TC = "45454545" }, 1000);
            Console.ReadLine();
        }
    }
}
