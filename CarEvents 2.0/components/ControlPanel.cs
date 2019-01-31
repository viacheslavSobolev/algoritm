using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents_2._0
{
    class ControlPanel
    {
        public AbstractTransport Transport { get; set; }
        
      
        public float Time { get; set; }
        
        public ControlPanel(AbstractTransport transport)
        {
           Transport = transport;                     
        }

       public void ShowPanel()
        {
            Console.WriteLine($" Fuel = {Transport.Fuel} \n " +
                               $" Time = {Time} sec \n " +
                               $" Current distance = {Transport.CurentDistance} ");
        }
        
        
    }
}
