using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class Tablet
    {
        public string Model { get; set; }
        public string Marka { get; set; }
        public Tablet (string model, string marka)
        {
            Model = model;
            Marka = marka;
        }

        public abstract void Accept(IVisitor visitor);
    }
}
