using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ThreeGVisitor : IVisitor
    {
        public void Visit(Tablet tablet)
        {
            if (tablet is IPad)
            {
                Console.WriteLine("IPad 3G desteklemiyor");
            }
            else if (tablet is GalaxyTab)
            {
                Console.WriteLine("GalaxyTab 3G acildi");
            }
            else
            {
                Console.WriteLine("Bu obje tablet degildir");
            }
        }
    }
}
