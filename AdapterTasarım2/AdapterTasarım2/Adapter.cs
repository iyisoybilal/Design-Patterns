using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterTasarım2
{
    public class Adapter : IFormat
    {
      private  Adaptee adaptee = new Adaptee();
        public void oynat()
        {
            adaptee.oynat();
        }
    }
}
