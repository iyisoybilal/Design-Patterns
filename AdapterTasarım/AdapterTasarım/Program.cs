using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterTasarım
{
    class Program
    {
        static void Main(string[] args)
        {
            Satıs satıs = new Adapter();
            satıs.siparisVer();
            Console.ReadLine();
        }
    }
}
