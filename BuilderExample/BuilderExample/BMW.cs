using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    public class BMW : ICarBuilder
    {
        public BMW()
        {
            car = new Car();
        }
        public override void Marka()
        {
            car.Marka = "BMW";
        }

        public override void Model()
        {
            car.Model = "E240";
        }

        public override void Yıl()
        {
            car.Yıl = "2020";
        }
    }
}
