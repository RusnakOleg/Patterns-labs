using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Composite
{
    internal class CarSalon : CarComponent
    {
        List<CarComponent> carComponents = new();
        public CarSalon(string name) : base(name)
        {
        }
        public override void Display()
        {
            Console.WriteLine($"Salon: {name}");
            foreach (var component in carComponents)
            {
                component.Display();
            }
        }

        public void AddComponent(CarComponent component)
        {
            carComponents.Add(component);
        }

        public void RemoveComponent(CarComponent component)
        {
            carComponents.Remove(component);
        }

    }
}
