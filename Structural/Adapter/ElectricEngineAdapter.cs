using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Adapter
{
    internal class ElectricEngineAdapter : IEngine
    {
        ElectricEngine electricEngine;
        public ElectricEngineAdapter(ElectricEngine electricEngine)
        {
            this.electricEngine = electricEngine;
        }
        public void Start()
        {
            electricEngine.TurnOn();
        }
    }
}
