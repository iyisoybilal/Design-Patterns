using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    public abstract class IKrediBasvuru
    {
        protected IKrediBasvuru krediBasvuru;
      
        public IKrediBasvuru SonrakiKontrol
        {
            set
            {
                krediBasvuru = value;
            }
        }
        public abstract void BilgiGönder(Customer customer);

    }
}
