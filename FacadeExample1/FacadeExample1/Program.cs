using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            Customer customer1 = new Customer() { CustomerName = "Bilal", CustomerNumber = 13123321, IDNo = "1231231", CashAmount = 1000 };
            Customer customer2 = new Customer() { CustomerName = "Ali", CustomerNumber = 13355, IDNo = "23554355", CashAmount = 2356166 };
            facade.SendEft(customer1, customer2, 1000);
            facade.KrediKullan(customer2);
            Console.ReadLine();
        }
    }
}
