using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Composite
{
    internal abstract class CarComponent
    {
        protected string name;
        public CarComponent(string name)
        {
            this.name = name;
        }
        public abstract void Display();
    }
}
