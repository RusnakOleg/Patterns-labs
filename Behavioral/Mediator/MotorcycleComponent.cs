using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Mediator
{
    internal abstract class MotorcycleComponent
    {
        protected Mediator mediator;

        public MotorcycleComponent(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void ProcessRequest(string request);
    }
}
