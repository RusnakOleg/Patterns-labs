using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Flyweight
{
    internal class Plane : AirTransport
    {
        public Plane(string model)
        {
            this.model = model;
        }
        public override void Fly(double latitude, double longitude)
        {
            Console.WriteLine($"Flying plane {model} to coordinates: {latitude} latitude and {longitude} longitude");
        }
    }
}
