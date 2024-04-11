using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Composite
{
    internal class Seat : CarComponent
    {
        public Seat(string name) : base(name)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"Seat: {name}");
        }
    }
}
