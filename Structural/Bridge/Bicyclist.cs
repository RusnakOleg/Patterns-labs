using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Bridge
{
    internal abstract class Bicyclist
    {
        protected IBicycle bicycle;
        public IBicycle Bicycle
        {
            set { bicycle = value; }
        }
        public Bicyclist(IBicycle bicycle)
        {
            this.bicycle = bicycle;     
        }

        public void Cycling()
        {
            bicycle.Start();
            bicycle.Stop();
        }

        public abstract void Compete();

        
    }
}
