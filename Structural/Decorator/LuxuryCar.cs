using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
    internal class LuxuryCar : Car
    {
        public LuxuryCar(string name) : base(name)
        {
        }

        public override int GetPrice()
        {
            return 50000;
        }
    }
}
