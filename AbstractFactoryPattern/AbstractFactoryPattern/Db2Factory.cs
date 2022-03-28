using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Db2Factory : IDatabaseFactory
    {
        public void CreateCommand()
        {
            new Db2Command();
        }

        public void CreateConnection()
        {
            new Db2Connection();    
        }
    }
}
