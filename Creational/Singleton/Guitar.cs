using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton
{
     class Guitar
    {
        private static Guitar instance;

        public string Name { get; set; }
        private static object syncRoot = new();

        public Guitar(string name)
        {
            Name = name;
        }

        public static Guitar GetInstance(string name)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new Guitar(name);         
                }
            }
            return instance;
        }
    }
}
