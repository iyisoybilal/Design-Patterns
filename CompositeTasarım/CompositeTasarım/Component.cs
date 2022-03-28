using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeTasarım
{
   public abstract class Component
    {
        protected Unvan unvan;
        protected string name;
        public Component(Unvan unvan,string name)
        {
            this.unvan = unvan;
            this.name = name;
        }
        public abstract void emirAl();
    }
}
