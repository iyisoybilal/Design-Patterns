using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Soket
    {
        public int Port { get; set; }
        public Soket (int Port)
        {
            this.Port = Port;
            State = new SoketStateAc();
        }
        private ISoketState  _State { get; set; }
        public ISoketState State
        {
            get { return _State; }
            set
            {
                _State = value;

            }
        }
        public void Do()
        {
            State.Handle(this);
        }
    }
}
