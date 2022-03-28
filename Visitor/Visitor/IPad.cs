using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class IPad : Tablet
    {
        public IPad(string model, string marka) : base(model, marka)
        {

        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
