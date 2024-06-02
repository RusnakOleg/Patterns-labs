using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Command
{
    internal class Truck
    {

        public void Accelerate(int speed)
        {
            Console.WriteLine($"Car accelerated to {speed} km/h");
        }

        public void Brake(int intensity) {
            Console.WriteLine($"Car braking with intensity {intensity}");
        }
    }
}
