using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Soket soket = new Soket(8080);
            soket.Do();
            soket.Do();
            soket.Do();
            soket.Do();

            Console.ReadKey();
        }
    }
}
