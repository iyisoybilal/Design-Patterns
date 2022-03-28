using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTasarım
{
    public class Pizza
    {
        public string PizzaTipi { get; set; }
        public string Hamur { get; set; }
        public string Sos { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", PizzaTipi, Hamur, Sos +"  " +"siparisiniz verilmistir");
        }
    }
}
