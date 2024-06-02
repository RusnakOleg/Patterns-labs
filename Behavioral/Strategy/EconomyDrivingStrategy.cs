using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy
{
    internal class EconomyDrivingStrategy : IDrivingStrategy
    {
        public void Drive()
        {
            Console.WriteLine("Driving in economy mode");
        }
    }
}
