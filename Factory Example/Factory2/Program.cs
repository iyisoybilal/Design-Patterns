using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabrika fabrika = new AFabrikası();
            ISınıf sınıf= fabrika.sınıf();
            sınıf.IsYap();
            //----------------------------------------
            IFabrika fabrika1 = new BFabrikası();
            ISınıf sınıf1 = fabrika1.sınıf();
            sınıf1.IsYap();
            Console.ReadLine();

        }
    }
}
