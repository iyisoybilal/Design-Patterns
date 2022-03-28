using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    public class ConcreteHandlerAvi : PlayerHandler
    {
        public override void Play(string filePath)
        {

            if (filePath.EndsWith(".avi"))
            {
                Console.WriteLine("{0} dosyası oynatılıyor(avi player)", filePath);
            }
            else
            {
                Console.WriteLine("{0} geçersiz dosya formatı",filePath);
            }
        }
    }
}
