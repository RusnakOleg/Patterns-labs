using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.ChainOfResponsibility
{
    internal class BrakesComponent : CarComponent
    {
        public override void ProcessRequest(string request)
        {
            if (request == "brake")
            {
                Console.WriteLine("Brakes applied");
            }
            else
            {
                Console.WriteLine("Wrong request");
            }
        }
    }
}
