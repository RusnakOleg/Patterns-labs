using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Adapter
{
    internal class Truck
    {
        public void StartEngine(IEngine engine)
        {
            engine.Start();
        }
    }
}
