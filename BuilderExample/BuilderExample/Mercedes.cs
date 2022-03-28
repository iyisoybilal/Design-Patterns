using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    public class Mercedes : ICarBuilder
    {
        
        public Mercedes()
        {
            car = new Car();
        } 
       
        public override void Marka()
        {
            car.Marka = "Mercedes";
        }

        public override void Model()
        {
            car.Model = "C180";
        }

        public override void Yıl()
        {
            car.Yıl = "2021";
        }
    }
}
