using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Momento
{
    internal class Train : Vehicle
    {
        public Train(string engineStatus, int speed) : base(engineStatus, speed) { }

        public TrainMemento CreateMemento()
        {
            return new TrainMemento(EngineStatus, Speed);
        }
        public void SetMemento(TrainMemento memento)
        {
            EngineStatus = memento.EngineStatus;
            Speed = memento.Speed;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Train -- Engine Status: {EngineStatus}, Speed: {Speed} km/h");
        }
    }
}
