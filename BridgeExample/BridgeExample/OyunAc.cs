using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample
{
   public abstract class OyunAc
    {
        protected IVideoMode videoMode;
        public OyunAc(IVideoMode videoMode)
        {
            this.videoMode = videoMode;
        }
        public virtual void OyunAcma()
        {
            videoMode.oynat();
        }
    }
}
