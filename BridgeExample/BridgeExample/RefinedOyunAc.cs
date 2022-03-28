using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample
{
   public class RefinedOyunAc : OyunAc
    { 
        public RefinedOyunAc(IVideoMode videoMode):base(videoMode)
        {
           
        }
        public override void OyunAcma()
        {
            base.OyunAcma();
        }
    }
}
