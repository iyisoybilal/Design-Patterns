using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class WifiVisitor : IVisitor
    {
        public void Visit(Tablet tablet)
        {
            if(tablet is IPad)
            {
                Console.WriteLine("IPad wifi acildi");
            }
            else if (tablet is GalaxyTab)
            {
                Console.WriteLine("GalaxyTab wifi acildi");
            }
            else
            {
                Console.WriteLine("Bu obje tablet degildir");
            }

        }
    }
}
