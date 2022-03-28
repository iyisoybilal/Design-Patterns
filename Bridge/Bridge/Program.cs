using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Abstraction(new ImplementA()).Operation());
            Console.WriteLine(new Abstraction(new ImplementB()).Operation());
            Console.ReadLine(); 
        }
    }
}
