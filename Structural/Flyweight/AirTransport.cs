using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Flyweight
{
    internal abstract class AirTransport
    {
        protected string model;
        public abstract void Fly(double latitude, double longitude);
    }
}
