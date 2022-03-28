using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    public class ConcreteHandlerMp4 : PlayerHandler
    {
        public override void Play(string filePath)
        {
            if (filePath.EndsWith(".mp4"))
            {
                Console.WriteLine("{0} dosyası oynatılıyor(mp4 player)", filePath);
            }
            else 
            {
                if (_SonrakiHandler != null)
                    _SonrakiHandler.Play(filePath);
            }
        }
    }
}
