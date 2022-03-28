using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterTasarım2
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormat format = new Adapter();
            format.oynat();
            Console.ReadLine();
        }
    }
}
