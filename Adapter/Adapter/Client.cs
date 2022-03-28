using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
   public class Client
    {
        public virtual void Siparis()
        {
            int Biftek = 75;
            int Hindi = 60;
            int Tavuk = 75;
            Console.WriteLine("Bifteğin fırında pişme süresi : " + Biftek);
            Console.WriteLine("Hindinin fırında pişme süresi : " + Hindi);
            Console.WriteLine("Tavuğun fırında pişme süresi : " + Tavuk);
        }
    }
}
