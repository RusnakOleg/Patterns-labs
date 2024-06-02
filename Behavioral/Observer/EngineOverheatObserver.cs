using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Observer
{
    internal class EngineOverheatObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Engine Overheat Observer: {message}");
        }
    }
}
