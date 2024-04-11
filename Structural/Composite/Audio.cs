using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Composite
{
    internal class Audio : CarComponent
    {
        public Audio(string name) : base(name)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"Audio: {name}");
        }
    }
}
