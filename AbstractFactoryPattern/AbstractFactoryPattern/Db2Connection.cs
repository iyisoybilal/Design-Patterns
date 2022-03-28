using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Db2Connection : Connection
    {
        public bool Connect()
        {
            Console.WriteLine("Db2 Bağlantısı Açılacak");
            return true;
        }

        public bool Disconnect()
        {
            Console.WriteLine("Db2 Bağlantısı Kapanacak");
            return true;
        }
    }
}
