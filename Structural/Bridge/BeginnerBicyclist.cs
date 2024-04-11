using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Bridge
{
    internal class BeginnerBicyclist : Bicyclist
    {
        public BeginnerBicyclist(IBicycle bicycle) : base(bicycle)
        {
        }

        public override void Compete()
        {
            Console.WriteLine("Can't take part in competitions");
        }
    }
}
