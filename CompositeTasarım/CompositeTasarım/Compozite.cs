using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeTasarım
{
    public class Compozite:IComposite
    {
        public List<Component> components = new List<Component>();
        public Compozite(Unvan unvan, string name) : base(unvan, name)
        {

        }

        public override void AskerEkle(Component component)
        {
            throw new NotImplementedException();
        }

        public override void emirAl()
        {
            throw new NotImplementedException();
        }
    }
}
