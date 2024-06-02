using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Observer
{
    internal class LowFuelObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Low Fuel Observer: {message}");
        }
    }
}
