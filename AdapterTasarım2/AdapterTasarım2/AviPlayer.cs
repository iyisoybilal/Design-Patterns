using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterTasarım2
{
    public class AviPlayer : IFormat
    {
        public void oynat()
        {
            Console.WriteLine("Dosya avi formatinda calisti");
        }
    }
}
