using Creational.Factory.Instruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory
{
    public class InstrumentFactory
    {
        public IMusicalInstrument CreateInstrument(string type)
        {
            switch (type)
            {
                case "saxophone":
                    return new Saxophone();
                case "accordion":
                    return new Accordion();
                case "drums":
                    return new Drums();
                default:
                    throw new ArgumentException("inccorect type of instrument");
            }
        }
    }
}
