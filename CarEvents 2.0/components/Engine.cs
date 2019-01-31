using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents_2._0
{
    
    class Engine
    {
        //public event EventHandler _SpeedInceased;
        //public event EventHandler _SpeedDecreases;
        public AbstractTransport transport;

        public Engine(AbstractTransport transport)
        {
            this.transport = transport;
        }

        
        
    }
}
