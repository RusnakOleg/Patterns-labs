using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade
{
    internal class VehicleManufacturingFacade
    {
        VehicleDesign design;
        VehicleFactory factory;
        VehicleSafety safety;

        public VehicleManufacturingFacade(VehicleDesign design, VehicleFactory factory, VehicleSafety safety)
        {
            this.design = design;
            this.factory = factory;
            this.safety = safety;
        }

        public void StartManufacturingProcess()
        {
            design.Design();
            design.PlanProduction();
            factory.Manufacture();
            factory.Assemble();
            safety.Test();
        }

        public void ReleaseVehicle()
        {
            safety.Release();
        }

    }
}
