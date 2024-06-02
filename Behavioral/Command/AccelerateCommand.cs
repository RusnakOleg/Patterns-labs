using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Command
{
    internal class AccelerateCommand : ICommand

    {
        private Truck truck;
        private int speed;

        public AccelerateCommand(Truck truck, int speed)
        {
           this.truck = truck;
           this.speed = speed;
        }
        public void Execute()
        {
            truck.Accelerate(speed);
        }
    }
}
