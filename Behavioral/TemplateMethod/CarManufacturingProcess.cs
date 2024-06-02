using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.TemplateMethod
{
    internal class CarManufacturingProcess : VehicleManufacturingProcess
    {
        protected override void AssembleFrame()
        {
            Console.WriteLine("Assembling car frame");
        }

        protected override void InstallEngine()
        {
            Console.WriteLine("Installing car engine");
        }

        protected override void Paint()
        {
            Console.WriteLine("Painting car");
        }

    }
}
