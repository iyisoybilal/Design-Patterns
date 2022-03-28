using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeUretici facadeUretici = new FacadeUretici();
            facadeUretici.ArabaUret();
            Console.ReadLine();
        }
    }
}
