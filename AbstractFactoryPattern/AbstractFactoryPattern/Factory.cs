using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
   public class Factory
    {
       private IDatabaseFactory _databaseFactory;
       private  Connection _connection;
       private Command _command;
        public Connection connection()
        {
            return new İnterbaseConnection();
           
        }
    }
}
