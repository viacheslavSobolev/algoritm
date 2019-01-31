using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents_2._0
{
    interface IComponents
    {
        Acelerator acelerator { get; set; }
        Engine engine { get; set; }
        ControlPanel panel { get; set; }
    }
}
