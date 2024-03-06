using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory.Instruments
{
    internal class Accordion : IMusicalInstrument
    {
        public void Play()
        {
            Console.WriteLine("Playing the accordion");
        }
    }
}
