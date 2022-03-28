using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    public abstract class ICarBuilder
    {
        protected Car car;
        public Car Car
        {
            get { return car; }
        }
        public abstract void Marka();
        public abstract void Model();
        public abstract void Yıl();

    }
}
