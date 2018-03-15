using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Environment
    {
        public string OperationSystem;
        public string IDE;
        public Environment(string _operation_system, string _ide)
        {
            OperationSystem = _operation_system;
            IDE = _ide;
        }
    }
}
