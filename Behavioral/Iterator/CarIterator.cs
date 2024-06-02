using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Iterator
{
    internal class CarIterator : ICarIterator
    {
        private ICarCollection collection;
        private int index = 0;

        public CarIterator(ICarCollection collection)
        {
            this.collection = collection;
        }

        public bool HasNext()
        {
            return index < collection.Count;
        }

        public Car Next()
        {
            return collection[index++];
        }
    }
}
