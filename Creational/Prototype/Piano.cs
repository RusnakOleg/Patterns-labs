using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype
{
    public class Piano : IPrototype
    {
        public string name;
        public Piano(string name)
        {
                this.name = name;
        }
        public IPrototype DoClone()
        {
            return new Piano(name);
        }   
        public override string ToString()
        {
            return "The model of piano is : " + name;
        }
    }
}
