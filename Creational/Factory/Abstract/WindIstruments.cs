using Creational.Factory.Instruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory.Abstract
{
    public class WindIstruments : InstrumentTypeFactory
    {
        public override IMusicalInstrument GetInstrument(string name)
        {
           switch (name)
            {
                case "trombone":
                    return new Trombone();
                case "trumpet":
                    return new Trumpet();
                default:
                    throw new ArgumentException("incorrect name of wind instrument");
            }
        }
    }
}
