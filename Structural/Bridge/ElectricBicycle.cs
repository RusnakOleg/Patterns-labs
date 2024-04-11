using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Bridge
{
    internal class ElectricBicycle : IBicycle
    {
        public void Start()
        {
            Console.WriteLine("The battery starts working");
        }

        public void Stop()
        {
            Console.WriteLine("The battery is off");
        }
    }
}
