using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    public class Car
    {
        public delegate void GetMessage(string m);        
      
        public class Acelerator
        {   
            public delegate void Events();
            static public event Events upSpeed;
            static public event Events downSpeed;
            
           static public void SpeedUp()
           {
                Console.WriteLine("Acelerator is Pressed");
                upSpeed += Engine.IncreasedSpeed;
                upSpeed += ControlPanel.SpeedometerUP;
                upSpeed += ControlPanel.FuelDOWN;
                upSpeed();
           }

           static  public void SpeedDown()
            {
                Console.WriteLine("Acelerator is unPressed");
                downSpeed += Engine.MoreGas;
                downSpeed += ControlPanel.SpeedometerDown;               
                downSpeed();
            }
        }


        public class Engine
        {                       
            public static void IncreasedSpeed()
            {
                Console.WriteLine("IncreasedSpeed");                
            }
            public static void MoreGas()
            {
                Console.WriteLine("DecreasedSpeed");
            }
        }

        public class ControlPanel
        {
            public static void SpeedometerUP()
            {
                Console.WriteLine("SpeedometerUP");
            }
            public static void SpeedometerDown()
            {
                Console.WriteLine("SpeedometerDOWN");
            }
           
            public static void FuelDOWN()
            {
                Console.WriteLine("FuelDecreased");
            }

        }

    }

    class Program
    {
        public static void Message(string m)
        {
            Console.WriteLine(m);
        }

        static void Main(string[] args)
        {
            Car.Acelerator.SpeedUp();
           

            Console.ReadKey();
        }
    }
}
