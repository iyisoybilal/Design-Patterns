using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    public class Car
    {
        public string  Marka { get; set; }
        public string  Model  { get; set; }
        public string Yıl { get; set; }
        public string Bilgi()
        {
            return $"{Marka} marka araba {Model} modelinde {Yıl} yılında üretilmiştir";
        }
    }
}
