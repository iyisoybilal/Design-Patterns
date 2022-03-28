using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            OyunAc oyunAc = new RefinedOyunAc(new OpenGL());
            oyunAc.OyunAcma();
            Console.ReadLine();
        }
    }
}
