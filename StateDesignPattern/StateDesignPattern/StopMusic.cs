using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class StopMusic : IState
    {
        public void Yap(State state)
        {
            Console.WriteLine("Müzik durduruldu");
            state.state = new PlayMusic();
        }
    }
}
