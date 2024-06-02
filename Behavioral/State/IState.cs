using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.State
{
    internal interface IState
    {
    void Start(Bicycle bicycle);
    void Pedal(Bicycle bicycle);
    void Brake(Bicycle bicycle);
    }
}
