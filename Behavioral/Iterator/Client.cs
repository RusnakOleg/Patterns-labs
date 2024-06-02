using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Iterator
{
    internal class Client
    {
        public void SeeAllCars(ICarCollection collection)
        {
            ICarIterator iterator = collection.CreateIterator();
            while (iterator.HasNext())
            {
                Car car = iterator.Next();
                Console.WriteLine(car.Brand);
            }
        }
    }
}
