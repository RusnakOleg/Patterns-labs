using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.TemplateMethod
{
    internal abstract class VehicleManufacturingProcess
    {
        public void ManufacturingProcess()
        {
            AssembleFrame();
            InstallEngine();
            Paint();
            Test();
            Deliver();
        }

        protected abstract void AssembleFrame();
        protected abstract void InstallEngine();
        protected abstract void Paint();

        protected virtual void Test()
        {
            Console.WriteLine("Testing the vehicle");
        }

        protected virtual void Deliver()
        {
            Console.WriteLine("Delivering the vehicle");
        }
    }
}
