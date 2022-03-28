using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Abstraction
    {
        Bridge bridge;
        public Abstraction(Bridge ımplement)
        {
            bridge = ımplement;
        }
        public string Operation()
        {
            return "Abstarction" + bridge.OperationImpl();
        }
    }
}
