using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class İnterbaseConnection : Connection
    {
        public bool Connect()
        {
            Console.WriteLine("İnterbase Bağlantısı Açılacak");
            return true;
        }

        public bool Disconnect()
        {
            Console.WriteLine("İnterbase Bağlantısı Kapatılacak");
            return true;
        }
    }
}
