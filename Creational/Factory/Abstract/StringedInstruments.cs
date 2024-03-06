using Creational.Factory.Instruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory.Abstract
{
    public class StringedInstruments : InstrumentTypeFactory
    {
        public override IMusicalInstrument GetInstrument(string name)
        {
            switch (name)
            {
                case "bass guitar":
                    return new BassGuitar();
                case "electric guitar":
                    return new ElectricGuitar();
                default:
                    throw new ArgumentException("incorrect name of stringed instrument");
            }
        }
    }
}
