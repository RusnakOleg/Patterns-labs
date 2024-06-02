using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Visitor
{
    internal interface IVisitor
    {
        void VisitEngine(BoatEngine engine);
        void VisitPropeller(Propeller propeller);
        void VisitSteeringWheel(SteeringWheel steeringWheel);
    }
}
