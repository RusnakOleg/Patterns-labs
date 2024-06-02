using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Visitor
{
    internal class BoatEngine : IBoatComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitEngine(this);
        }
    }
}
