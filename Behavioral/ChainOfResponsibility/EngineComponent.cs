using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.ChainOfResponsibility
{
    internal class EngineComponent : CarComponent
    {
        public override void ProcessRequest(string request)
        {
            if (request == "start")
            {
                Console.WriteLine("Engine starts");
                nextComponent?.ProcessRequest("shift"); 
            }
            else
            {
                nextComponent?.ProcessRequest(request);
            }
        }
    }


}
