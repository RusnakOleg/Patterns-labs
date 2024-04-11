using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Flyweight
{
    internal class AirTransportFactory
    {
        private Dictionary<string, AirTransport> vehicles = new();


        public AirTransport GetAirTransport(string model, string type)
        {
            string key = $"{type}_{model}";

            if (!vehicles.ContainsKey(key))
            {
                if (type == "Plane")
                    vehicles[key] = new Plane(model);
                else if (type == "Helicopter")
                    vehicles[key] = new Helicopter(model);
                else
                    throw new ArgumentException("Wrong vehicle type");
            }
            return vehicles[key];
        }
    }
}
