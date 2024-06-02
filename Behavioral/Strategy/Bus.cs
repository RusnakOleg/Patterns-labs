using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy
{
    internal class Bus
    {
        private IDrivingStrategy drivingStrategy;

        public Bus(IDrivingStrategy strategy)
        {
            this.drivingStrategy = strategy;
        }

        public void SetDrivingStrategy(IDrivingStrategy strategy)
        {
            this.drivingStrategy = strategy;
        }

        public void Drive()
        {
            drivingStrategy.Drive();
        }
    }
}
