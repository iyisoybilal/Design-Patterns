using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            State state = new State();
            state.Do();
            state.Do();
            state.Do();
            Console.ReadLine();
        }
    }
}
