using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Observer
{
    internal class Plane : ISubject
    {
        private readonly List<IObserver> engineObservers = new List<IObserver>();
        private readonly List<IObserver> fuelObservers = new List<IObserver>();
        private bool isEngineOverheating = false;
        private bool isLowFuel = false;

        public void Attach(IObserver observer)
        {
            if (observer is EngineOverheatObserver)
            {
                engineObservers.Add(observer);
            }
            else if (observer is LowFuelObserver)
            {
                fuelObservers.Add(observer);
            }
        }

        public void Detach(IObserver observer)
        {
            engineObservers.Remove(observer);
            fuelObservers.Remove(observer);
        }

        public void Notify()
        {
            if (isEngineOverheating)
            {
                foreach (var observer in engineObservers)
                {
                    observer.Update("Engine is overheating!");
                }
                isEngineOverheating = false;
            }
            if (isLowFuel)
            {
                foreach (var observer in fuelObservers)
                {
                    observer.Update("Low fuel level!");
                }
                isLowFuel = false;
            }
        }

        public void EngineOverheat()
        {
            isEngineOverheating = true;
            Notify();
        }

        public void LowFuel()
        {
            isLowFuel = true;
            Notify();
        }
    }

}
