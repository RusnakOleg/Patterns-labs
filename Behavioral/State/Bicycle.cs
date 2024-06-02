using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.State
{
    internal class Bicycle
    {
        private IState state;

        public Bicycle()
        {
            state = new StoppedState();
        }

        public void SetState(IState newState)
        {
            state = newState;
        }

        public void Start()
        {
            state.Start(this);
        }

        public void Pedal()
        {
            state.Pedal(this);
        }

        public void Brake()
        {
            state.Brake(this);
        }
    }
}
