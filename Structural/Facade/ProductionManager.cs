using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade
{
    internal class ProductionManager
    {
        public void ManageManufacturing(VehicleManufacturingFacade facade)
        {
            facade.StartManufacturingProcess();
            facade.ReleaseVehicle();
        }
    }
}
