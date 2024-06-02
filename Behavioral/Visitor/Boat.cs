using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Visitor
{
    internal class Boat : IBoatComponent
    {
        private List<IBoatComponent> components = new List<IBoatComponent>();

        public void AddComponent(IBoatComponent component)
        {
            components.Add(component);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}
