using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace try_events
{
    public class Car
    {
        public event EventHandler carEndedFuel;
        public int Fuel { get; private set; }
        public string MessageFuel { get; private set; }
        public int FuelConsumption { get; private set; }
        
        public Car(int f,string m,int fc)
        {           
            Fuel = f;
            MessageFuel = m;
            FuelConsumption = fc;
        }

        public void Work()
        {
            for (int i = Fuel; i >= 0; i--)
            {
                if (i == 0 )
                {
                    carEndedFuel?.Invoke(this.MessageFuel, new EventArgs());
                }
                
                Thread.Sleep(FuelConsumption);               
            }
        }

    }

  
    public static class Messeges
    {
        public static void Messages(object o,EventArgs e)          
        {
            Console.WriteLine(o);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Car lada = new Car(12,"lada is empty",1000);
            Car renoult = new Car(6,"renoult is empty",1500);
           
            lada.carEndedFuel += Messeges.Messages;
            renoult.carEndedFuel += Messeges.Messages;

            lada.Work();
            renoult.Work();
            Console.ReadKey();
        }
        
    }
}
