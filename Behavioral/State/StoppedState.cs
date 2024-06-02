using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.State
{
    internal class StoppedState : IState
    {
        public void Start(Bicycle bicycle)
        {
            Console.WriteLine("Bicycle is starting...");
            bicycle.SetState(new MovingState());
        }

        public void Pedal(Bicycle bicycle)
        {
            Console.WriteLine("Cannot pedal, bicycle is stopped");
        }

        public void Brake(Bicycle bicycle)
        {
            Console.WriteLine("Cannot brake, bicycle is already stopped");
        }
    }
}
