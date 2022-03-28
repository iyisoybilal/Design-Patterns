using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class State
    {
        public State()
        {
            stateDurum = new PlayMusic();
        }
        public IState stateDurum;
        public IState state
        {
            set
            {
                stateDurum = value;
            }
        }
        public void Do()
        {
            stateDurum.Yap(this);
        }
    }
}
