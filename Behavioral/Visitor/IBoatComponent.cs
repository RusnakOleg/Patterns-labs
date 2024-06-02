using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Visitor
{
    internal interface IBoatComponent
    {
        void Accept(IVisitor visitor);
    }
}
