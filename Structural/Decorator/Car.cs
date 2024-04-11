using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
    internal abstract class Car 
    {
        public string Name { get; set; }
        public abstract int GetPrice();
        public Car(string name)
        {
            Name = name;
        }
    }
}
