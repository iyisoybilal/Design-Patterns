using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeTasarım
{
    public class Taksi
    {
       private string sinif;
        public Taksi(string sinif)
        {
            this.sinif = sinif;
        }
        public void TaksiCagir()
        {
            Console.WriteLine(sinif + "Taksisi Cagirildi");
        }

    }
}
