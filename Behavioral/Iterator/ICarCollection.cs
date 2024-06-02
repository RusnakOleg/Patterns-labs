using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Iterator
{
    internal interface ICarCollection
    {
        ICarIterator CreateIterator();
        int Count { get; }
        Car this[int index] { get; }
    }
}
