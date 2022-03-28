using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IPad iPad = new IPad("Ipad mini", "Apple");
            GalaxyTab galaxyTab = new GalaxyTab("GalaxyTab", "Samsung");
            iPad.Accept(new WifiVisitor());
            galaxyTab.Accept(new ThreeGVisitor());
            iPad.Accept(new ThreeGVisitor());
            Console.ReadLine();
        }
    }
}
