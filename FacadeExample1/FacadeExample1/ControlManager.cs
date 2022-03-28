using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample1
{
   public static class ControlManager
    {
        public static bool ParaKontrol(Customer customer, decimal amount)
        {
            if (customer.CashAmount >= amount)
            {
                return true;
            }
            else
                return false;   
        }
        public static bool KrediKontrol(string IDNo)
        {
            return true;
        }
    }
}
