using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Servis
    {
        public void Biftek()
        {
            Console.WriteLine("Biftek için fırında pisme süresi=30 dk; \n "+ "kalori=75 kal");
        }
        public void Tavuk()
        {
            Console.WriteLine("Tavuk için fırında pisme süresi=40 dk; \n " + "kalori=70 kal");
        }
        public void Hindi()
        {
            Console.WriteLine("Hindi için fırında pisme süresi=45 dk; \n " + "kalori=85 kal");
        }
    }
}
