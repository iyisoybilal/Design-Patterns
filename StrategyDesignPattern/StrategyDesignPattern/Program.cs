using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            OdemeIslemleri odemeIslemleri = new OdemeIslemleri(new BankaTransfer());
            odemeIslemleri.Pay();
            Console.ReadLine();
        }
    }
}
