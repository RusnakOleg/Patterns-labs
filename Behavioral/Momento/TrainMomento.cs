using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Momento
{
    internal class TrainMemento : Vehicle
    {
        public TrainMemento(string engineStatus, int speed) : base(engineStatus, speed) { }
    }
}
