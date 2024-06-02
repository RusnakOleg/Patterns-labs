using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.TemplateMethod
{
    internal class TruckManufacturingProcess : VehicleManufacturingProcess
    {
        protected override void AssembleFrame()
        {
            Console.WriteLine("Assembling truck frame");
        }

        protected override void InstallEngine()
        {
            Console.WriteLine("Installing truck engine");
        }

        protected override void Paint()
        {
            Console.WriteLine("Painting truck");
        }

        protected override void Test()
        {
            base.Test();
            Console.WriteLine("Additional testing for truck");
        }

    }
}
