using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
    internal class HeatedSeatsDecorator : CarDecorator
    {
        public HeatedSeatsDecorator(Car car) : base(car.Name, car)
        {
        }

        public override int GetPrice()
        {
            return car.GetPrice() + 800;
        }
    }
}
