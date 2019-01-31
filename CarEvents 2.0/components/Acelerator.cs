using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents_2._0
{
    public class Acelerator
    {
        //public event EventHandler _Pressed;
       // public event EventHandler _UnPressed;
        public AbstractTransport transport;
      
        public Acelerator(AbstractTransport transport)
        {
            this.transport = transport;
        }
        //public  void Pressed()
        //{           

        //}
        //public void UnPressed()
        //{
            
        //}
    }
}
