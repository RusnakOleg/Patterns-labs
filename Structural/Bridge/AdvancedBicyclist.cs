using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Bridge
{
    internal class AdvancedBicyclist : Bicyclist
    {
        public AdvancedBicyclist(IBicycle bicycle) : base(bicycle)
        {
        }

        public override void Compete()
        {
            Console.WriteLine("Can take part in competitions");
        }
    }
}
