using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Flyweight
{
    internal class Helicopter : AirTransport
    {
        public Helicopter(string model)
        {
            this.model = model;
        }
        public override void Fly(double latitude, double longitude)
        {
            Console.WriteLine($"Flying helicopter {model} to coordinates: {latitude} latitude and {longitude} longitude");
        }
    }
}
