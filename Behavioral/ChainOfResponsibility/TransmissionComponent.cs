using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.ChainOfResponsibility
{
    internal class TransmissionComponent : CarComponent
    {
        public override void ProcessRequest(string request)
        {
            if (request == "shift")
            {
                Console.WriteLine("Transmission shifts gears");
                nextComponent?.ProcessRequest("brake");
            }
            else
            {
                nextComponent?.ProcessRequest(request);
            }
        }
    }
}
