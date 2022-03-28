using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    public class MonsterHdd : IHdd
    {
        public void ParcaÜret()
        {
            Console.WriteLine("Monster Hdd Üretildi");
        }
    }
}
