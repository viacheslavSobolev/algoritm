using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GC
{
    class Program:IDisposable
    {
        public void Dispose()
        { Console.WriteLine(); }

        private static void TimerCallback(object o)
        {
            Console.WriteLine(DateTime.Now);          
        }
        static void Main(string[] args)
        {
            LinkedList<string> linkList = new LinkedList<string>();
            Dictionary<int, string> countries = new Dictionary<int, string>
            {
                [1]="hello",[2]="lalal",[3] = "tralala"
            };
            foreach (KeyValuePair<int, string> item in countries)
            {
                Console.WriteLine(item.Key + "-" +item.Value);
            }

            Timer timer = new Timer(TimerCallback,null,0,1000);
            Thread.Sleep(3000);
            timer = null;
            System.GC.Collect(); 
            Console.ReadLine();
        }
       
    }
}
