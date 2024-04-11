using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Proxy
{
    internal class WorkerProxy : IWorker
    {
        private Worker worker;
        public WorkerProxy(string name)
        {
            worker = new Worker(name);
        }

        public void LogIn()
        {
            Console.WriteLine("Enterted time registration...");
            worker.LogIn();
        }

        public void LogOut()
        {
            Console.WriteLine("Leave time registration...");
            worker.LogOut();
        }
    }
}
