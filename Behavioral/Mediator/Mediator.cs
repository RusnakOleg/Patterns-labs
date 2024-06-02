using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Mediator
{
    internal abstract class Mediator
    {
        public abstract void Notify(MotorcycleComponent component, string action);
    }
}
