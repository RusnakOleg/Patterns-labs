using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Command
{
    internal class TruckDriver
    {

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();  
        }
    }
}
