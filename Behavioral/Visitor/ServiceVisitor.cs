using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Visitor
{
    internal class ServiceVisitor : IVisitor
    {
        public void VisitEngine(BoatEngine engine)
        {
            Console.WriteLine("Servicing boat engine");
        }

        public void VisitPropeller(Propeller propeller)
        {
            Console.WriteLine("Servicing propeller");
        }

        public void VisitSteeringWheel(SteeringWheel steeringWheel)
        {
            Console.WriteLine("Servicing steering wheel");
        }
    }
}
