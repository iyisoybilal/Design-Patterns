using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class PlayMusic : IState
    {
        public void Yap(State state)
        {
            Console.WriteLine("Müzik oynatılıyor");
            state.state = new StopMusic();
        }
    }
}
