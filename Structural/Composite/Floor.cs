using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Composite
{
    internal class Floor : CarComponent
    {
        public Floor(string name) : base(name)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"Floor: {name}");
        }
    }
}
