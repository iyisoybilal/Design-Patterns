using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class AnneObserver : Observer
    {
        public override void Uptade()
        {
            Console.WriteLine("Öğrencinin kaçtığından annesinin haberi oldu");
        }
    }
}
