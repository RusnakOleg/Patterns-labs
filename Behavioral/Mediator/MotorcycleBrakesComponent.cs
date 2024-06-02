using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Mediator
{
    internal class MotorcycleBrakesComponent : MotorcycleComponent
    {
        public MotorcycleBrakesComponent(Mediator mediator) : base(mediator) { }

        public override void ProcessRequest(string request)
        {
            Console.WriteLine($"BrakesComponent: Processing request '{request}'");
            mediator.Notify(this, request);
        }
    }
}
