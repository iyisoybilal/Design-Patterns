using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeTasarım
{
   public  abstract class IComposite:Component
    {
        
        public IComposite(Unvan unvan,string name):base(unvan,name)
        {

        }
        public abstract void AskerEkle(Component component);
    }
}
