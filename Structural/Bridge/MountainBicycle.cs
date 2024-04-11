using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Bridge
{
    internal class MountainBicycle : IBicycle
    {
        public void Start()
        {
            Console.WriteLine("Begins to climb the mountain");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped on the mountain");
        }
    }
}
