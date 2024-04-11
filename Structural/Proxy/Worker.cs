using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Proxy
{
    internal class Worker : IWorker
    {
        private string name;
        public Worker(string name)
        {
              this.name = name;
        }
        public void LogIn()
        {
            Console.WriteLine($"{name} entered the workplace");
        }

        public void LogOut()
        {
            Console.WriteLine($"{name} left the workplace");
        }
    }
}
