using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory.Instruments
{
    public class Saxophone : IMusicalInstrument
    {
        public void Play()
        {
            Console.WriteLine("Playing the saxophone");
        }
    }
}
