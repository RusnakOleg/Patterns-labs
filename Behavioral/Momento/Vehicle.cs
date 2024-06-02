using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Momento
{
    internal class Vehicle
    {
        public string EngineStatus { get; set; }
        public int Speed { get; set; }

        public Vehicle(string engineStatus, int speed)
        {
            EngineStatus = engineStatus;
            Speed = speed;
        }
    }
}
