using Behavioral.ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Mediator
{
    internal class MotorcycleMediator : Mediator
    {
        private MotorcycleEngineComponent engine;
        private MotorcycleGearboxComponent gearbox;
        private MotorcycleBrakesComponent brakes;

        public void RegisterEngine(MotorcycleEngineComponent engine)
        {
            this.engine = engine;
        }

        public void RegisterGearbox(MotorcycleGearboxComponent gearbox)
        {
            this.gearbox = gearbox;
        }

        public void RegisterBrakes(MotorcycleBrakesComponent brakes)
        {
            this.brakes = brakes;
        }

        public override void Notify(MotorcycleComponent component, string action)
        {
            if (component == engine)
            {
                if (action == "start")
                {
                    Console.WriteLine("Mediator: Starting the engine...");
                    gearbox.ProcessRequest("shift");
                }
            }
            else if (component == gearbox)
            {
                if (action == "shift")
                {
                    Console.WriteLine("Mediator: Shifting gears...");
                    brakes.ProcessRequest("brake");
                }
            }
        }
    }
}
