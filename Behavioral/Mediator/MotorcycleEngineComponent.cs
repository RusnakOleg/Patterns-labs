using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Mediator
{
    internal class MotorcycleEngineComponent : MotorcycleComponent
    {
        public MotorcycleEngineComponent(Mediator mediator) : base(mediator) { }

        public override void ProcessRequest(string request)
        {
            Console.WriteLine($"EngineComponent: Processing request '{request}'");
            mediator.Notify(this, request);
        }
    }
}
