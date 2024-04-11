using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
    internal class LowPricedCar : Car
    {
        public LowPricedCar(string name) : base(name)
        {
        }

        public override int GetPrice()
        {
            return 2000;
        }
    }
}
