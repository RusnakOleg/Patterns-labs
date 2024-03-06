using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory.Abstract
{
    public class MusicalStoreFactory
    {
        public InstrumentTypeFactory GetInstrumentTypeFactory(string type)
        {
            switch (type)
            {
                case "stringed":
                    return new StringedInstruments();
                case "brass":
                    return new WindIstruments();
                default:
                    throw new ArgumentException("incorrect type of musical instruments");
            }
        }
    }
}
