using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.State
{
    internal class MovingState : IState
    {
        public void Start(Bicycle bicycle)
        {
            Console.WriteLine("Bicycle is already started");
        }

        public void Pedal(Bicycle bicycle)
        {
            Console.WriteLine("Bicycle is pedaling...");
        }

        public void Brake(Bicycle bicycle)
        {
            Console.WriteLine("Bicycle is braking...");
            bicycle.SetState(new StoppedState());
        }
    }
}
