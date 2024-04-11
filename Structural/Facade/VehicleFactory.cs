using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade
{
    internal class VehicleFactory
    {
        public void Manufacture()
        {
            Console.WriteLine("Manufacturing the vehicle");
        }
        public void Assemble()
        {
            Console.WriteLine("Assembling the vehicle components");
        }
    }
}
