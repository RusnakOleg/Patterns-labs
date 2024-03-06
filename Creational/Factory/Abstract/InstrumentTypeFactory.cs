using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory.Abstract
{
    public abstract class InstrumentTypeFactory
    {
        public abstract IMusicalInstrument GetInstrument(string name);
    }
}