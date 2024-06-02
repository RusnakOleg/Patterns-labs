using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Mediator
{
    internal class MotorcycleGearboxComponent: MotorcycleComponent
{
    public MotorcycleGearboxComponent(Mediator mediator) : base(mediator) { }

    public override void ProcessRequest(string request)
    {
        Console.WriteLine($"GearboxComponent: Processing request '{request}'");
        mediator.Notify(this, request);
    }
}
}
