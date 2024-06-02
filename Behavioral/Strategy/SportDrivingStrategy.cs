using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy
{
    internal class SportDrivingStrategy : IDrivingStrategy
    {
        public void Drive()
        {
            Console.WriteLine("Driving in sport mode");
        }
    }

}
