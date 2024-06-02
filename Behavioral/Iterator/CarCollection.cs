using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Iterator
{
    internal class CarCollection : ICarCollection
    {
        private Car[] cars;

    public CarCollection()
    {
        cars =
        [
            new Car("Toyota"),
            new Car("Honda"),
            new Car("Ford"),
            new Car("Mercedes"),
            new Car("Skoda")
        ];
    }

    public int Count => cars.Length;

    public Car this[int index] => cars[index];

    public ICarIterator CreateIterator()
    {
        return new CarIterator(this);
    }
    }
}
