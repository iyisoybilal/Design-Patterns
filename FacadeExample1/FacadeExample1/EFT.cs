using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample1
{
    public class EFT
    {
        public void SendEft(Customer fromCustomer,Customer toCostumer,decimal eftAmount)
        {
            if (ControlManager.ParaKontrol(fromCustomer,eftAmount))
            {
                fromCustomer.CashAmount -= eftAmount;
                Console.WriteLine("EFT" + toCostumer.CustomerNumber + "nolu hesaba gönderildi");
            }
            else
                Console.WriteLine("Bakiye yetersiz EFT işleminiz gerçekleştirilemedi");
        }
    }
}
