using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTasarım2
{
    public class Pizza
    {
        public string  PizzaTipi { get; set; }
        public  string Hamur  { get; set; }
        public string  Sos { get; set; }
        public string MalzemeEkranBas()
        {
            return $"{PizzaTipi} tipinde, {Hamur} hamurlu, {Sos} soslu pizza yapildi";
        }
    }
}
