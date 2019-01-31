using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarEvents_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();
            train.Start();
            Car car = new Car();
            car.Start();
            Plane plane = new Plane();
            plane.Start();

            Console.WriteLine($"Winner:{ResultRacing.GetWiner().TransportName} !!! Time = {ResultRacing.GetWiner().Time}");
            Console.Read();           
        }
    }
}
