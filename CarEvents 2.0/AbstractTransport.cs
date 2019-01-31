using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarEvents_2._0
{
    public abstract class AbstractTransport
    {       
        public delegate void Procedure();
        public event Action<string, AbstractTransport> _EndRacing;       
        public event Procedure _ShowPanel;

        public int DistanceTraveled { get; set; } //дистанция забега
        public float Fuel { get; set; } // текущее кол-во топлива
        public int Speed { get; set; } //скорость тс
        public float FuelConsumption { get; set; } //расход топлива тс
        public string TransportName { get; set; }
        public int CurentDistance { get; set; }


         Acelerator acelerator { get; set; }
         Engine engine { get; set; }
         ControlPanel panel { get; set; }

       
        
      
        public AbstractTransport(string transportName,float fuelConsumption,float fuel,int speed,int distanceTraveled = 3000)
        {
            Speed = speed;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            DistanceTraveled = distanceTraveled;
            TransportName = transportName;
            acelerator = new Acelerator(this);
            engine = new Engine(this);
            panel = new ControlPanel(this);
            _ShowPanel += panel.ShowPanel;
            _EndRacing += EndRacing;
           
        }

        public void Start()
        {
            panel.Time = 0;
            CurentDistance = default;    
            Console.WriteLine($"{TransportName} started whis fuel = {Fuel},speed = {Speed}");            
            Move();
        }       

        public void EndRacing(string message, AbstractTransport transport)
        {
                          
            Console.WriteLine($"-----------------------\n" +
            $"{transport.TransportName} {message}");
            _ShowPanel();
            Console.WriteLine($"Statistic of {TransportName}:\n " +
                              $"elapsedTime = {panel.Time}\n" +
                              $" Speed = {Speed}\n");          
            ResultRacing.Results.Add(new Result { TransportName = this.TransportName, Time = panel.Time });
        }
         
        
       
        void Move()
        {           
            int count = 0;
            for (int c = DistanceTraveled; c > 0; DistanceTraveled--, Fuel -= FuelConsumption / 100000)
            {
                CurentDistance += 1;
                count++;
                if (count == 100)
                {                   
                    panel.Time += 100/Speed;
                    Console.WriteLine($"remaining distance of {TransportName} {DistanceTraveled}\n ");
                    _ShowPanel();
                    count = 0;
                }

                if (Fuel <= 0)
                {
                    _EndRacing("the race is over.Fuel is done", this);                   
                    break;
                }
                if (DistanceTraveled <= 0)
                {
                    _EndRacing("the race is over.", this);                    
                    break;
                }
                               
            }
        }
      
    }
}


