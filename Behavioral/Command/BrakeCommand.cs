using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Command
{
    internal class BrakeCommand : ICommand
    {
        private Truck truck;
        private int intensity;

        public BrakeCommand(Truck truck, int intensity)
        {
            this.truck = truck;
            this.intensity = intensity;
        }
        public void Execute()
        {
            truck.Brake(intensity);
        }
    }
}
