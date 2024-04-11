using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
    internal abstract class CarDecorator : Car
    {
        protected Car car;
        protected CarDecorator(string name, Car car) : base(name)
        {
            this.car = car;
        }
    }
}
