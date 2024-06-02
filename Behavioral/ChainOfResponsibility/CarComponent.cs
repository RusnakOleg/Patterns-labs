using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.ChainOfResponsibility
{
    internal abstract class CarComponent
    {
        protected CarComponent nextComponent;

        public void SetNextComponent(CarComponent component)
        {
            nextComponent = component;
        }

        public abstract void ProcessRequest(string request);
    }
}
