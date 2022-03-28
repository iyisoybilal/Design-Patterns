using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class GalaxyTab : Tablet
    {
        public GalaxyTab(string model,string marka) : base(marka, model)
        {

        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
